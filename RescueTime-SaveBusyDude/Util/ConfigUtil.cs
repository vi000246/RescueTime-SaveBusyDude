using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.Script.Serialization;
using System.Windows.Forms;
using RescueTime_SaveBusyDude.Model;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using RescueTime_SaveBusyDude.BLL;

namespace RescueTime_SaveBusyDude
{
    /// <summary>
    /// 和設置相關的method
    /// </summary>
    public static class ConfigUtil
    {
        //多做這一層的用意是，要改Config的儲存位置時，可以在這裡切換
        public static ConfigFactory _config = new ConfigFactory(EnumModule.ConfigFileType.Local);

        public static ConfigModel.JsonConfig GetJsonConfigData()
        {
            return ErrorHandle.Execute(() => _config.GetJsonConfigData());
        }

        public static ConfigModel.AlertRecord GetAlertRecordByName(string name)
        {
            return ErrorHandle.Execute(() =>_config.GetAlertRecordByName(name));
        }

        public static void InsertUpdateApiKey(string key)
        {
            ErrorHandle.Execute(() => _config.InsertUpdateApiKey(key));
        }

        public static void InsertUpdateAlertRule(ConfigModel.AlertRule alertRule)
        {
            ErrorHandle.Execute(() => _config.InsertUpdateAlertRule(alertRule));
        }

        public static void InsertUpdateAlertRecord(ConfigModel.AlertRecord alertRecord)
        {
            ErrorHandle.Execute(() => _config.InsertUpdateAlertRecord(alertRecord));
        }

        public static void InsertUpdateFocusSetting(ConfigModel.FocusSetting setting)
        {
            ErrorHandle.Execute(() => _config.InsertUpdateFocusSetting(setting));
        }

        public static void InsertUpdatePeriodRule(ConfigModel.PeriodRule periodRule)
        {
            ErrorHandle.Execute(()=>_config.InsertUpdatePeriodRule(periodRule));
        }

        public static void DeleteAlertRuleByName(string alertName)
        {
            ErrorHandle.Execute(()=>_config.DeleteAlertRuleByName(alertName));
        }

        public static void DeletePeriodRuleByName(string periodName)
        {
            ErrorHandle.Execute(()=>_config.DeletePeriodRuleByName(periodName));
        }

        public static ConfigModel.SystemSetting GetSystemSetting()
        {
            return ErrorHandle.Execute(()=>_config.GetSystemSetting());
        }

        public static void UpdateSystemSetting(ConfigModel.SystemSetting setting)
        {
            ErrorHandle.Execute(() => _config.UpdateSystemSetting(setting));
        }

        public static ConfigModel.PeriodRule GetPeriodRuleByPeriodName(string periodName, ConfigModel.JsonConfig config = null)
        {
            if (config == null)
                config = GetJsonConfigData();
            return ErrorHandle.Execute(() => _config.GetPeriodRuleByPeriodName(config,periodName));
        }

        public static T Deserialize<T>(string data)
        {
            return ErrorHandle.Execute(() => JsonConvert.DeserializeObject<T>(data),"Cannot parse json file,please check json file format.");
        }

    }
}
