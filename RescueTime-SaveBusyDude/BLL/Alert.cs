using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using RescueTime_SaveBusyDude.Model;

namespace RescueTime_SaveBusyDude.BLL
{
    public class Alert
    {
        /// <summary>
        /// 取得在指定period中，指定的AlertType所花費的時間
        /// </summary>
        /// <param name="alertRule"></param>
        /// <param name="data"></param>
        /// <returns>如果累計時間超過alertRule指定的時間，就回傳true</returns>
        public bool CheckTimeSpendIsExceedByAlertTypeAndPeriod(ConfigModel.AlertRule alertRule, List<ApiActivityResponse> data)
        {
            bool result = false;
            var config = ConfigUtil.GetJsonConfigData();
            //取得Period by period name
            List<ConfigModel.PeriodRule> periodList = alertRule.PeriodName.Select(x=>ConfigUtil.GetPeriodRuleByPeriodName(config,x)).ToList();

            //依照period，取得總花費時間
            Func<ApiActivityResponse, bool> FilterDataByPeriod = (ApiActivityResponse x) =>
            {
                bool filterResult = false;
                if (periodList.Count == 0)
                    return true;

                foreach (var period in periodList)
                {
                    if (period.Hour_begin <= x.Date.Hour|| x.Date.Hour <= period.Hour_end)
                    {
                        filterResult = true;
                    }
                }
                return filterResult;
            };

            //依照AlertType跟period，取得data
            switch (alertRule.AlertType)
            {
                case EnumModule.AlertType.SpecificCategory:
                case EnumModule.AlertType.SpecificActivity:
                    data = data
                        .Where(x => (x.Category == alertRule.SpecificName || x.Activity == alertRule.SpecificName) && FilterDataByPeriod(x))
                        .ToList();
                    break;
                case EnumModule.AlertType.All:
                    data = data.Where(x => FilterDataByPeriod(x)).ToList();
                    break;
                case EnumModule.AlertType.AllDistractingTime:
                    data = data.Where(x => x.Productivity < 0 && FilterDataByPeriod(x)).ToList();
                    break;
                case EnumModule.AlertType.AllProductiveTime:
                    data = data.Where(x => x.Productivity > 0 && FilterDataByPeriod(x)).ToList();
                    break;
            }

            
            int TotalSpendTime = data.Sum(x=>x.TimeSpent);

            //判斷總花費時間有沒有超過
            int limitTime = (alertRule.Hour * 60 + alertRule.Minute) * 60;
            if (TotalSpendTime > limitTime)
            {
                result = true;
            }

            return result;
        }

        public void AddAlertRecordToJsonConfig()
        {
        }

    }
}
