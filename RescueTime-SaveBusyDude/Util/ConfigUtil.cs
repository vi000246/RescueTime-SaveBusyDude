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
            return _config.GetJsonConfigData();
        }

        public static void InsertUpdateApiKey(string key)
        {
            _config.InsertUpdateApiKey(key);
        }

        public static void InsertUpdateAlertRule(ConfigModel.AlertRule alertRule)
        {
            _config.InsertUpdateAlertRule(alertRule);
        }

        public static void InsertUpdateAlertRecord(ConfigModel.AlertRecord alertRecord)
        {
            _config.InsertUpdateAlertRecord(alertRecord);
        }

        public static void InsertUpdateFocusSetting(ConfigModel.FocusSetting setting)
        {
            _config.InsertUpdateFocusSetting(setting);
        }

        public static void InsertUpdatePeriodRule(ConfigModel.PeriodRule periodRule)
        {
            _config.InsertUpdatePeriodRule(periodRule);
        }

        public static void DeleteAlertRuleByName(string alertName)
        {
            _config.DeleteAlertRuleByName(alertName);
        }

        public static void DeletePeriodRuleByName(string periodName)
        {
            _config.DeletePeriodRuleByName(periodName);
        }

        public static ConfigModel.SystemSetting GetSystemSetting()
        {
            return _config.GetSystemSetting();
        }

        public static ConfigModel.PeriodRule GetPeriodRuleByPeriodName(ConfigModel.JsonConfig config,string periodName)
        {
            var rule = config.Period.FirstOrDefault(x => x.PeriodName == periodName);
            if (rule == null)
            {
                MessageBox.Show("Cannot  find period rule by period name");
                throw new Exception("Cannot  find period rule by period name");
            }
            return rule;
        }

        public static T Deserialize<T>(string data)
        {
            T obj = default(T);
            try
            {
                obj = JsonConvert.DeserializeObject<T>(data);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Cannot parse json file,please check json format. \nErrorMsg:\n"+ex.Message);
            }
            return obj;
        }
    }
}
