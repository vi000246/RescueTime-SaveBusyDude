using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RescueTime_SaveBusyDude.Model
{
    public class LocalJsonConfig : IConfig
    {
        public string _jsonFileName = "AppConfig.json";
        public ConfigModel.JsonConfig GetJsonConfigData()
        {
            using (StreamReader r = new StreamReader(_jsonFileName))
            {
                string json = r.ReadToEnd();
                ConfigModel.JsonConfig config = ConfigUtil.Deserialize<ConfigModel.JsonConfig>(json);
                return config;

            }
        }
        public void UpdateJsonConfigData(ConfigModel.JsonConfig newJsonObj)
        {
            var modifiedJsonString = Newtonsoft.Json.JsonConvert.SerializeObject(newJsonObj);
            File.WriteAllText(_jsonFileName, modifiedJsonString);
        }
    }
}
