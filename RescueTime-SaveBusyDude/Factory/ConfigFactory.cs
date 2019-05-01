using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Reflection;
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

        public ConfigModel.PeriodRule GetPeriodRuleByPeriodName(ConfigModel.JsonConfig config, string periodName)
        {
            return _config.GetPeriodRuleByPeriodName(config, periodName);
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

        //取得本地的系統設置
        public ConfigModel.SystemSetting GetSystemSetting()
        {
            var setting = new ConfigModel.SystemSetting();
            setting.JsonBinSecretKey = ConfigurationManager.AppSettings["JsonBinSecretKey"];
            setting.JsonBinPath = ConfigurationManager.AppSettings["JsonBinPath"];
            setting.IsEnableLog = Boolean.Parse(ConfigurationManager.AppSettings["IsEnableLog"] ?? "false");
            setting.AlertScanInterval = int.Parse(ConfigurationManager.AppSettings["AlertScanInterval"] ?? "300");
            setting.IsEnableJsonBin = bool.Parse(ConfigurationManager.AppSettings["IsEnableJsonBin"] ?? "false");
            return setting;
        }

        public void UpdateSystemSetting(ConfigModel.SystemSetting setting)
        {
            Configuration configuration = ConfigurationManager.
            OpenExeConfiguration(Assembly.GetExecutingAssembly().Location);
            configuration.AppSettings.Settings["JsonBinSecretKey"].Value = setting.JsonBinSecretKey;
            configuration.AppSettings.Settings["JsonBinPath"].Value = setting.JsonBinPath;
            configuration.AppSettings.Settings["IsEnableLog"].Value = setting.IsEnableLog.ToString();
            configuration.AppSettings.Settings["IsEnableJsonBin"].Value = setting.IsEnableJsonBin.ToString();
            configuration.AppSettings.Settings["AlertScanInterval"].Value = setting.AlertScanInterval.ToString();
            configuration.Save();
            ConfigurationManager.RefreshSection("appSettings");
        }
    }
}
