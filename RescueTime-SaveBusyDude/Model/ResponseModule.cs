using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace RescueTime_SaveBusyDude
{
    /// <summary>
    /// 用來放置API回傳json的module
    /// </summary>
    public class ApiActivityResponse
    {
        public DateTime Date { get; set; }
        public int TimeSpent { get; set; }//花費時間 單位:秒
        public int NumberOfPeople { get; set; }
        public string Activity { get; set; }//程式名稱
        public string Category { get; set; }//程式分類
        public EnumModule.Productivity Productivity { get; set; }//生產力程度
    }

    public class DataApiResponse
    {
        public string notes { get; set; }
        public List<string> row_headers { get; set; }
        public List<List<string>> rows { get; set; }
    }
}
