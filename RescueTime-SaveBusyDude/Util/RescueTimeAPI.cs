using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RescueTime_SaveBusyDude
{
    public static class RescueTimeAPI
    {
        public const string AnalyticDataAPI_URL = "https://www.rescuetime.com/anapi/data?";

        /// <summary>
        /// 
        /// </summary>
        /// <param name="perspective">排名、間隔</param>
        /// <param name="resolution_time">month、week、hour、day、minute</param>
        /// <param name="restrict_kind">要取得的資料類型 category、activity、productivity..etc</param>
        /// <param name="restrict_begin">時間begin</param>
        /// <param name="restrict_end">時間end</param>
        /// <param name="restrict_thing">要取得的物件名稱 ex.domain name、程式名稱</param>
        /// <param name="restrict_thingy">用來搜尋視窗標題</param>
        /// <returns></returns>
        public static string BuildQueryString( 
            EnumModule.perspective perspective, EnumModule.resolution_time resolution_time, EnumModule.restrict_kind restrict_kind,
            string restrict_begin,string restrict_end,string restrict_thing,string restrict_thingy)
        {

            return "";
        }

        /// <summary>
        /// Productivity分成2 ~ -2
        /// </summary>
        public static void GetData()
        {

        }

        //依據名稱或url，找出此進程的生產力程度 用來做block
        public static EnumModule.Productivity GetProductivityByProcessName(string name)
        {
            throw new NotImplementedException();
        }
    }
}
