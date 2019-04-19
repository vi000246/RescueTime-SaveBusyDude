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

        public ConfigModel.AlertRecord GetAlertRecordByName(string name)
        {
            return _config.GetAlertRecordByName(name);
        }

        public void InsertUpdateApiKey(string key)
        {
            _config.InsertUpdateApiKey(key);
        }

        public void InsertUpdateAlertRule(ConfigModel.AlertRule alertRule)
        {
            _config.InsertUpdateAlertRule(alertRule);
        }

        public void InsertUpdateAlertRecord(ConfigModel.AlertRecord alertRecord)
        {
            _config.InsertUpdateAlertRecord(alertRecord);
        }

        public void InsertUpdateFocusSetting(ConfigModel.FocusSetting setting)
        {
            _config.InsertUpdateFocusSetting(setting);
        }

        public void InsertUpdatePeriodRule(ConfigModel.PeriodRule periodRule)
        {
            _config.InsertUpdatePeriodRule(periodRule);
        }

        public void DeleteAlertRuleByName(string alertName)
        {
            _config.DeleteAlertRuleByName(alertName);
        }

        public void DeletePeriodRuleByName(string periodName)
        {
            _config.DeletePeriodRuleByName(periodName);
        }

        //this method should be private
        //        public ConfigModel.JsonConfig UpdateJsonConfigData(ConfigModel.JsonConfig newJsonObj)
        //        {
        //            _config.UpdateJsonConfigData(newJsonObj);
        //            return _config.GetJsonConfigData();
        //        }

        //取得本地的系統設置
        public ConfigModel.SystemSetting GetSystemSetting()
        {
            throw new NotImplementedException();
        }
    }
}
