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
        public bool CheckTimeSpendIsExceedByAlertTypeAndPeriod(ConfigModel.AlertRule alertRule, List<ApiActivityResponse> data,ConfigModel.JsonConfig config = null)
        {
            bool result = false;
            if(config == null)
                config = ConfigUtil.GetJsonConfigData();
            //取得Period by period name
            List<ConfigModel.PeriodRule> periodList = alertRule.PeriodName.Select(x=>ConfigUtil.GetPeriodRuleByPeriodName(config,x)).ToList();
            //會觸發Alert的時段
            List<ConfigModel.PeriodRule> EnableAlertPeriodList = alertRule.EnablePeriodName.Select(x => ConfigUtil.GetPeriodRuleByPeriodName(config, x)).ToList();

            //判斷是否執行Alert
            bool IsEnableAlert = false;
            var TodayWeekDay = (EnumModule.WeekDays)((int)DateTime.Now.DayOfWeek);
            if (alertRule.EnableDays.Contains(TodayWeekDay) )
            {
                foreach (var period in EnableAlertPeriodList)
                {
                    if (CheckTimeBetweenTwoHour(DateTime.Now.Hour, period.Hour_begin, period.Hour_end))
                    {
                        IsEnableAlert = true;
                    }
                }
            }

            if (!IsEnableAlert)
                return false;

            //Func<> 用在where條件，依照period，取得總花費時間
            Func<ApiActivityResponse, bool> FilterDataByPeriod = (ApiActivityResponse x) =>
            {
                bool filterResult = false;
                if (periodList.Count == 0)
                    return true;

                foreach (var period in periodList)
                {
                    //p.s. 這裡的hour_end判斷是用小於，沒有等於
                    filterResult = CheckTimeBetweenTwoHour(x.Date.Hour,period.Hour_begin,period.Hour_end);
                }
                return filterResult;
            };

            //依照AlertType跟period，取得data
            switch (alertRule.AlertType)
            {
                case EnumModule.AlertType.SpecificCategory:
                    data = data
                        .Where(x => alertRule.SpecificName.Contains(x.Category, StringComparer.OrdinalIgnoreCase)&&
                                    FilterDataByPeriod(x))
                        .ToList();
                    break;
                case EnumModule.AlertType.SpecificActivity:
                    data = data
                        .Where(x => alertRule.SpecificName.Contains(x.Activity, StringComparer.OrdinalIgnoreCase) &&
                                    FilterDataByPeriod(x))
                        .ToList();
                    break;
                case EnumModule.AlertType.SpecificCategoryOrActivity:
                    data = data
                        .Where(x => (alertRule.SpecificName.Contains(x.Category,StringComparer.OrdinalIgnoreCase)||
                                     alertRule.SpecificName.Contains(x.Activity, StringComparer.OrdinalIgnoreCase)) &&
                                    FilterDataByPeriod(x))
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

        public string DisplayAlertProcess(List<ApiActivityResponse> data, ConfigModel.JsonConfig config = null)
        {
            string alertMsg = string.Empty;
            if(config == null)
                config = ConfigUtil.GetJsonConfigData();

            foreach (var alertRule in config.Alert)
            {
                var IsShowAlert = CheckTimeSpendIsExceedByAlertTypeAndPeriod(alertRule,data,config);
                var HasShowAlertToday = CheckAlertHasDisplayToday(alertRule.alertName);
                if (IsShowAlert && !HasShowAlertToday)
                {
                    //組回傳字串
                    alertMsg += "\n" + BuildAlertMessage(alertRule);
                    //紀錄到AlertRecord
                    ConfigUtil.InsertUpdateAlertRecord(new ConfigModel.AlertRecord(alertRule.alertName,DateTime.Now.Date));
                }
            }

            return alertMsg;
        }

        private string BuildAlertMessage(ConfigModel.AlertRule alertRule)
        {
            string activitys = string.Empty;
            switch (alertRule.AlertType)
            {
                case EnumModule.AlertType.All:
                    activitys = "總使用時間";
                    break;
                case EnumModule.AlertType.AllDistractingTime:
                    activitys = "總Distracting使用時間";
                    break;
                case EnumModule.AlertType.AllProductiveTime:
                    activitys = "總Productive使用時間";
                    break;
                case EnumModule.AlertType.SpecificActivity:
                case EnumModule.AlertType.SpecificCategory:
                case EnumModule.AlertType.SpecificCategoryOrActivity:
                    activitys = string.Join(",", alertRule.SpecificName);
                    break;
            }
            return $"【{activitys}】\n 於 〔{alertRule.PeriodName}〕\n 已滿 {alertRule.Hour} 小時 {alertRule.Minute} 分";
        }

        private bool CheckAlertHasDisplayToday(string name)
        {
            var record = ConfigUtil.GetAlertRecordByName(name);
            if (record != null && (DateTime.Now.Date - record.AlertDate).TotalDays == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private bool CheckTimeBetweenTwoHour(int hour,int hour_begin,int hour_end)
        {
            if (hour_begin <= hour || hour < hour_end)
            {
                return true;
            }
            return false;
        }

    }
}
