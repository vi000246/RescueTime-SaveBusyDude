using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.Script.Serialization;
using RescueTime_SaveBusyDude.Model;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace RescueTime_SaveBusyDude
{
    /// <summary>
    /// 和設置相關的method
    /// </summary>
    public static class ConfigUtil
    {
        public static ConfigModel.JsonConfig GetJsonConfigData()
        {
            using (StreamReader r = new StreamReader("AppConfig.json"))
            {
                string json = r.ReadToEnd();
                ConfigModel.JsonConfig config = Deserialize<ConfigModel.JsonConfig>(json);
                return config;
            }
        }

        public static T Deserialize<T>(string data)
        {
            return JsonConvert.DeserializeObject<T>(data);
        }
    }
}
