using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RescueTime_SaveBusyDude
{
    /// <summary>
    /// 用來放置API回傳json的module
    /// </summary>
    public class ResponseModule
    {
        public class activity
        {
            public int Rank { get; set; }//排名
            public int TimeSpent { get; set; }//花費時間 單位:秒
            public string Activity { get; set; }//程式名稱
            public string Category { get; set; }//程式分類
            public int Productivity { get; set; }//生產力程度
        }
    }
}
