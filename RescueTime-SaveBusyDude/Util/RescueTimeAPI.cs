using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Net;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using HtmlAgilityPack;
using RescueTime_SaveBusyDude.Model;

namespace RescueTime_SaveBusyDude
{
    public static class RescueTimeAPI
    {
        #region private method
        private const string AnalyticDataAPI_URL = "https://www.rescuetime.com/anapi/data";

        /// <summary>
        /// 
        /// </summary>
        /// <param name="perspective">排名、間隔</param>
        /// <param name="resolution_time">month、week、hour、day、minute</param>
        /// <param name="restrict_kind">要取得的資料類型 category、ApiActivityResponse、productivity..etc</param>
        /// <param name="restrict_begin">時間begin</param>
        /// <param name="restrict_end">時間end</param>
        /// <param name="restrict_thing">要取得的物件名稱 ex.domain name、程式名稱，用了這個選項，會回傳視窗標題，而不是domain name</param>
        /// <param name="restrict_thingy">用來搜尋視窗標題,好像沒有用</param>
        /// <returns></returns>
        private static string BuildQueryString( 
            EnumModule.perspective perspective = EnumModule.perspective.rank,
            EnumModule.resolution_time resolution_time = EnumModule.resolution_time.hour,
            EnumModule.restrict_kind restrict_kind = EnumModule.restrict_kind.activity,
            string restrict_begin = "",string restrict_end = "",string restrict_thing = "",string restrict_thingy = "",
            ConfigModel.JsonConfig config = null)
        {
            if(config ==null)
                config = ConfigUtil.GetJsonConfigData();

            var queryParams = new NameValueCollection()
            {
                { "key", config.Apikey },
                { "perspective", perspective.ToString() },
                { "resolution_time", resolution_time.ToString() },
                { "restrict_kind", restrict_kind.ToString() },
                { "restrict_begin", restrict_begin },
                { "restrict_end", restrict_end },
                { "restrict_thing", restrict_thing },
                { "restrict_thingy", restrict_thingy },
            };

            return AnalyticDataAPI_URL + ToQueryString(queryParams);

        }
        private static string ToQueryString(NameValueCollection nvc)
        {
            StringBuilder sb = new StringBuilder("?");

            bool first = true;

            foreach (string key in nvc.AllKeys)
            {
                foreach (string value in nvc.GetValues(key))
                {
                    if (!first)
                    {
                        sb.Append("&");
                    }

                    sb.AppendFormat("{0}={1}", Uri.EscapeDataString(key), Uri.EscapeDataString(value));

                    first = false;
                }
            }

            return sb.ToString();
        }

        private static T GetDataFromApi<T>(string url)
        {
            var html = new WebClient().DownloadString(url);
            //只取得<body>裡的字串
            var json = GetJsonDataFromHtml(html);
            T response = ConfigUtil.Deserialize<T>(json);
            return response;
        }

        //API會回傳html 取得body裡的json
        private static string GetJsonDataFromHtml(string html)
        {
            var doc = new HtmlDocument();
            doc.LoadHtml(html);
            var body = doc.DocumentNode.Descendants("body").FirstOrDefault();
            return body.InnerHtml.ToString();
        }

        public static List<ApiActivityResponse> ConvertJsonArrayToApiActivityResponse(DataApiResponse rawData)
        {
            return ConvertStringArrayToClass(rawData.rows);
        }

        #endregion

        public static List<ApiActivityResponse> ConvertStringArrayToClass(List<List<string>> rows)
        {
            var destination = new List<ApiActivityResponse>(rows.Count);
            foreach (var r in rows)
            {
                destination.Add(new ApiActivityResponse
                {
                    Date = DateTime.Parse(r[0]),
                    TimeSpent = int.Parse(r[1]),
                    NumberOfPeople = int.Parse(r[2]),
                    Activity = r[3],
                    Category = r[4],
                    Productivity = (EnumModule.Productivity)int.Parse(r[5])

                });
            }

            return destination;
        }


        public static List<ApiActivityResponse> GetActivityDataByHour(DateTime? date_begin = null, DateTime? date_end = null)
        {
            string strDateBegin = date_begin.HasValue ? date_begin.Value.ToString("yyyy-MM-dd") : "";
            string strDateEnd = date_end.HasValue ? date_end.Value.ToString("yyyy-MM-dd") : "";

            var url = BuildQueryString(perspective: EnumModule.perspective.interval,restrict_begin: strDateBegin,restrict_end:strDateEnd);
            var rawData = GetDataFromApi<DataApiResponse>(url);
            return ConvertJsonArrayToApiActivityResponse(rawData);
        }

        public static List<ApiActivityResponse> GetAllActivityData(DateTime? date_begin = null, DateTime? date_end = null)
        {
            string strDateBegin = date_begin.HasValue ? date_begin.Value.ToString("yyyy-MM-dd") : "";
            string strDateEnd = date_end.HasValue ? date_end.Value.ToString("yyyy-MM-dd") : "";

            var url = BuildQueryString(perspective: EnumModule.perspective.interval, restrict_begin: strDateBegin, restrict_end: strDateEnd, resolution_time: EnumModule.resolution_time.week);
            var rawData = GetDataFromApi<DataApiResponse>(url);
            return ConvertJsonArrayToApiActivityResponse(rawData);
        }


        //判斷此程式、domain name或分類名稱存不存在,用來設置block list
        public static bool IsActivityOrCategoryExist()
        {
            throw new NotImplementedException();
        }

        //依據名稱或url，找出此進程的生產力程度 用來做block
        public static EnumModule.Productivity GetProductivityByProcessName(string name)
        {
            throw new NotImplementedException();
        }
    }
}
