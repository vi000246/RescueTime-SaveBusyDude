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
        public ConfigModel.JsonConfig GetJsonConfigData()
        {
            using (StreamReader r = new StreamReader("AppConfig.json"))
            {
                string json = r.ReadToEnd();
                ConfigModel.JsonConfig config = ConfigUtil.Deserialize<ConfigModel.JsonConfig>(json);
                return config;

            }
        }
    }
}
