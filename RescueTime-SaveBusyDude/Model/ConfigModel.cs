using System;
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
            public int hour
            {
                get { return hour; }
                set
                {
                    hour = (value < 0) ? 0 : (value > 24) ? 24 : value;
                }
            }
            public int minute
            {
                get { return minute; }
                set
                {
                    minute = (value < 0) ? 0 : (value > 60) ? 60 : value;
                }
            }
            public EnumModule.AlertType AlertType { get; set; }
            public string CategoryName { get; set; }
            public string PeriodName { get; set; }
            public string CustomMessage { get; set; }
            public bool BlockWhenTrigger { get; set; }
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
            public string PeriodName { get; set; }
            public int hour_begin
            {
                get { return hour_begin; }
                set
                {
                    hour_begin = (value < 0) ? 0 : (value > 24) ? 24 : value;
                }
            }
            public int hour_end {
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
