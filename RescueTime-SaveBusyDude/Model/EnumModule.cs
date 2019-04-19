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
            rank = 1,//perspective設定為rank resolution_time就會沒作用
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
            category = 1,//會回傳每個category的每個interval的總花費時間
            activity = 2,//會回傳每個activity的每個interval總花費時間
            productivity = 3,
            efficiency = 4, //only when perspective is "interval"
            document = 5,
            overview = 6
        }

        // 生產力程度 分成2 ~ -2五個等級
        public enum Productivity
        {
            VeryDistracting = -2,
            Distraction = -1,
            Neutral = 0,
            Productive = 1,
            VeryProductive = 2
        }

        /// <summary>
        /// Config檔的存放位置，Local是存放在本機，JSonBin是存放在JsonBin
        /// </summary>
        public enum ConfigFileType
        {
            Local,
            JsonBin
        }

        /// <summary>
        /// FocusTime的模式
        /// Normal:block VeryDistracting
        /// Intermediate:block VeryDistracting跟Distraction
        /// Strick:block non Productive
        /// ActivityAndCategory:block by activity、domain name or category name
        /// </summary>
        public enum BlockingMode
        {
            Normal,
            Intermediate,
            Strick,
            ActivityAndCategory
        }

        /// <summary>
        /// 會觸發alert的類型
        /// AllTime:總時間達到就會觸發
        /// AllProductiveTime:總專注時間達到會觸發
        /// AllDistractingTime:總分心時間達到會觸發
        /// SpecificCategory:特定類別累積時間達到會觸發
        /// SpecificActivity:特定程式或是domain name 
        /// </summary>
        public enum AlertType
        {
            All,
            AllProductiveTime,
            AllDistractingTime,
            SpecificCategory,
            SpecificActivity,
            SpecificCategoryOrActivity
        }

        public enum WeekDays
        {
            Sunday, Monday, Tuesday, Wednesday, Thursday, Friday, Saturday
        }

    }
}
