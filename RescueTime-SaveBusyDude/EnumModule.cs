using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RescueTime_SaveBusyDude
{
    /// <summary>
    /// 用來放置參數設置相關的enum
    /// </summary>
    public class EnumModule
    {

        public enum perspective
        {
            rank = 1,
            interval = 2,
            member = 3
        }

        public enum resolution_time
        {
            month = 1,
            week = 2,
            day=3,
            hour = 4,
            minute = 5
        }

        public enum restrict_kind
        {
            category = 1,
            activity = 2,
            productivity = 3,
            efficiency = 4, //only when perspective is "interval"
            document = 5
        }


    }
}
