using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RescueTime_SaveBusyDude.Model
{
    public class ConfigFactory
    {
        public IConfig _config;

        public ConfigFactory(EnumModule.ConfigFileType configType)
        {
            switch (configType)
            {
                case EnumModule.ConfigFileType.JsonBin:
                    _config = new JsonBinConfig();
                    break;
                case EnumModule.ConfigFileType.Local:
                    _config = new LocalJsonConfig();
                    break;
            }
        }

        public ConfigModel.JsonConfig GetJsonConfigData()
        {
            return _config.GetJsonConfigData();
        }

        public void UpdateJsonConfigData(ConfigModel.JsonConfig newJsonObj)
        {
            _config.UpdateJsonConfigData(newJsonObj);
        }
    }
}
