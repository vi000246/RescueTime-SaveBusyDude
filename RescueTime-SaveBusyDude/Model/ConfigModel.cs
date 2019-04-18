﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            public int Hour
            {
                get { return hour; }
                set
                {
                    hour = (value < 0) ? 0 : (value > 24) ? 24 : value;
                }
            }
            public int Minute
            {
                get { return minute; }
                set
                {
                    minute = (value < 0) ? 0 : (value > 60) ? 60 : value;
                }
            }
            public EnumModule.AlertType AlertType { get; set; }
            public string CategoryName { get; set; }//如果AlertType是SpecificCategory，就計算此目錄的總計時間
            public string PeriodName { get; set; }//設定何時觸發?待處理
            public string CustomMessage { get; set; }
            public bool BlockWhenTrigger { get; set; }//當觸發alert rule時，阻擋這個AlertType
            public DateTime ShowAlertTime { get; set; }//紀錄顯示alert的時間，防止重覆提醒
        }

        public class AlertRecord
        {
            public string AlertName { get; set; }
            public DateTime AlertDate { get; set; }
        }

        public class FocusSetting
        {
            public bool IsEnable { get; set; }
            public int Duration { get; set; }
            public EnumModule.BlockingMode BlockingMode { get; set; }
        }

        public class PeriodRule
        {
            private int hour_begin = 0;
            private int hour_end = 0;
            public string PeriodName { get; set; }
            public int Hour_begin
            {
                get { return hour_begin; }
                set
                {
                    hour_begin = (value < 0) ? 0 : (value > 24) ? 24 : value;
                }
            }
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
    }
}
