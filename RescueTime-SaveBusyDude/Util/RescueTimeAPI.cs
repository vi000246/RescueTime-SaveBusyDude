using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RescueTime_SaveBusyDude
{
    public static class RescueTimeAPI
    {
        public const string AnalyticDataAPI_URL = "";

        public static string BuildQueryString( 
            EnumModule.perspective perspective, EnumModule.resolution_time resolution_time, EnumModule.restrict_kind restrict_kind)
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
