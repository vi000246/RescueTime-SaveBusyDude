using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using RescueTime_SaveBusyDude.Helper;

namespace RescueTime_SaveBusyDude.Model
{
    public class ConfigModel
    {
        public class JsonConfig
        {
            public string Apikey { get; set; }
            public List<AlertRule> Alert { get; set; }
            public List<AlertRecord> AlertRecord { get; set; }
            public FocusSetting Focus { get; set; }
            public List<PeriodRule> Period { get; set; }
        }

        public class AlertRule
        {
            private int hour = 0;
            private int minute = 0;
            [ColumnIndex(0)]
            public string alertName { get; set; }

            //累計時間所需達到的小時數
            [ColumnIndex(2)]
            public int Hour
            {
                get { return hour; }
                set
                {
                    hour = (value < 0) ? 0 : (value > 24) ? 24 : value;
                }
            }
            //累計時間所需達到的分鐘數
            [ColumnIndex(3)]
            public int Minute
            {
                get { return minute; }
                set
                {
                    minute = (value < 0) ? 0 : (value > 60) ? 60 : value;
                }
            }

            [JsonConverter(typeof(StringEnumConverter))]
            [ColumnIndex(1)]
            public EnumModule.AlertType AlertType { get; set; }//只計算指定的Activity或是Productivity或是category
            [ColumnIndex(4)]
            public string[] SpecificName { get; set; }//如果AlertType是SpecificCategory或是SpecificActivity，就計算此目錄的總計時間
            [ColumnIndex(5)]
            public string[] PeriodName { get; set; }//用來統計此period內的總計時間，如果為空，預設撈全部
            [ColumnIndex(9)]
            public string CustomMessage { get; set; }
            [ColumnIndex(8)]
            public bool BlockWhenTrigger { get; set; }//當觸發alert rule時，阻擋這個AlertType
            [JsonProperty(ItemConverterType = typeof(StringEnumConverter))]
            [ColumnIndex(6)]
            public List<EnumModule.WeekDays> EnableDays { get; set; }//設定alert要執行的星期
            [ColumnIndex(7)]
            public string[] EnablePeriodName { get; set; }//設定alert要執行的period，如果為空，預設全時段都會觸發alert
        }

        public class AlertRecord
        {
            public AlertRecord(string alertName,DateTime AlertDate)
            {
                this.AlertName = alertName;
                this.AlertDate = AlertDate;
            }
            public string AlertName { get; set; }
            public DateTime AlertDate { get; set; }
        }

        public class FocusSetting
        {
            public bool IsEnable { get; set; }
            public int Duration { get; set; }

            [JsonConverter(typeof(StringEnumConverter))]
            public EnumModule.BlockingMode BlockingMode { get; set; }

            /// <summary>
            /// 只有當BlockingMode是ActivityAndCategory才有作用
            /// </summary>
            public List<string> blockingList { get; set; }
        }

        public class PeriodRule
        {
            private int hour_begin = 0;
            private int hour_end = 0;
            [ColumnIndex(0)]
            public string PeriodName { get; set; }
            [ColumnIndex(1)]
            public int Hour_begin
            {
                get { return hour_begin; }
                set
                {
                    hour_begin = (value < 0) ? 0 : (value > 24) ? 24 : value;
                }
            }
            [ColumnIndex(2)]
            public int Hour_end {
                get { return hour_end; }
                set
                {
                    hour_end = (value < 0) ? 0: (value > 24) ? 24: value;
                }
            }

            private bool validateHour(int hour)
            {
                if (hour < 0 || hour > 24)
                {
                    return false;
                }
                return true;
            }
        }


        public class SystemSetting
        {
            public string JsonBinSecretKey { get; set; }
            public string JsonBinPath { get; set; }
            public bool IsEnableLog { get; set; }
            public int AlertScanInterval { get; set; }
            public bool IsEnableJsonBin { get; set; }
        }

    }　
}
