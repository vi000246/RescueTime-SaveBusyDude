using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace RescueTime_SaveBusyDude.Model
{
    public class LocalJsonConfig : IConfig
    {
        public string _jsonFileName = "AppConfig.json";
        public ConfigModel.JsonConfig _config = null;

        public LocalJsonConfig()
        {
            RefreshConfigData();
        }

        private void RefreshConfigData()
        {
            ConfigModel.JsonConfig config = null;
            using (StreamReader r = new StreamReader(_jsonFileName, System.Text.Encoding.Default))
            {
                string json = r.ReadToEnd();
                config = ConfigUtil.Deserialize<ConfigModel.JsonConfig>(json);
            }

            if (config != null &&
                (config.Alert != null || config.AlertRecord != null || config.Apikey != null || config.Focus != null || config.Period != null))
            {
                this._config = config;
            }
            else
            {
                //如果抓不到config 就init一個新的
                UpdateJsonConfigData(new ConfigModel.JsonConfig()
                {
                    Apikey = "",Alert = new List<ConfigModel.AlertRule>(),AlertRecord = new List<ConfigModel.AlertRecord>(),
                    Focus = new ConfigModel.FocusSetting(),Period = new List<ConfigModel.PeriodRule>()
                });
            }
        }

        public ConfigModel.JsonConfig GetJsonConfigData()
        {
            return _config;
        }

        public ConfigModel.AlertRecord GetAlertRecordByName(string name)
        {
            var record = _config.AlertRecord.FirstOrDefault(s => String.Equals(s.AlertName, name, StringComparison.CurrentCultureIgnoreCase));
            return record;
        }

        private void UpdateJsonConfigData(ConfigModel.JsonConfig newJsonObj)
        {
            var modifiedJsonString = Newtonsoft.Json.JsonConvert.SerializeObject(newJsonObj);
            File.WriteAllText(_jsonFileName, modifiedJsonString, Encoding.UTF8);
            RefreshConfigData();
        }

        public void InsertUpdateApiKey(string key)
        {
            _config.Apikey = key;
            UpdateJsonConfigData(_config);
            RefreshConfigData();
        }

        public void InsertUpdateAlertRule(ConfigModel.AlertRule alertRule)
        {
            var OldRuleIndex = _config.Alert.FindIndex(c => c.alertName.Equals(alertRule.alertName, StringComparison.OrdinalIgnoreCase));
            if (OldRuleIndex > -1)
            {
                _config.Alert[OldRuleIndex] = alertRule;
            }
            else
            {
                _config.Alert.Add(alertRule);
            }
            UpdateJsonConfigData(_config);
            RefreshConfigData();
        }

        public void InsertUpdateAlertRecord(ConfigModel.AlertRecord alertRecord)
        {

            var OldRuleIndex = _config.AlertRecord.FindIndex(c => c.AlertName.Equals(alertRecord.AlertName, StringComparison.OrdinalIgnoreCase));
            if (OldRuleIndex > -1)
            {
                _config.AlertRecord[OldRuleIndex] = alertRecord;
            }
            else
            {
                _config.AlertRecord.Add(alertRecord);
            }
            UpdateJsonConfigData(_config);
            RefreshConfigData();
        }

        private void DeleteAlertRecordByName(string Name) {
            var OldRuleIndex = _config.AlertRecord.FindIndex(c => c.AlertName.Equals(Name, StringComparison.OrdinalIgnoreCase));
            if (OldRuleIndex > -1)
            {
                _config.AlertRecord.RemoveAt(OldRuleIndex);
            }
            UpdateJsonConfigData(_config);
            RefreshConfigData();
        }

        public void InsertUpdateFocusSetting(ConfigModel.FocusSetting setting)
        {
            _config.Focus = setting;
            UpdateJsonConfigData(_config);
            RefreshConfigData();
        }

        public void InsertUpdatePeriodRule(ConfigModel.PeriodRule periodRule)
        {
            var OldRuleIndex = _config.Period.FindIndex(c => c.PeriodName == periodRule.PeriodName);
            if (OldRuleIndex > -1)
            {
                _config.Period[OldRuleIndex] = periodRule;
            }
            else
            {
                _config.Period.Add(periodRule);
            }
            UpdateJsonConfigData(_config);
            RefreshConfigData();
        }

        public void DeleteAlertRuleByName(string alertName)
        {
            var OldRuleIndex = _config.Alert.FindIndex(c => c.alertName.Equals(alertName, StringComparison.OrdinalIgnoreCase));
            if (OldRuleIndex > -1)
            {
                _config.Alert.RemoveAt(OldRuleIndex);
                //順便刪除alertRecord
                DeleteAlertRecordByName(alertName);
            }
            else
            {
                throw new ArgumentException("Cannot find specific alert rule");
            }
            UpdateJsonConfigData(_config);
            RefreshConfigData();
        }

        public void DeletePeriodRuleByName(string periodName)
        {
            var OldRuleIndex = _config.Period.FindIndex(c => c.PeriodName == periodName);
            if (OldRuleIndex > -1)
            {
                _config.Period.RemoveAt(OldRuleIndex);
            }
            else
            {
                throw new ArgumentException("Cannot find specific period rule");
            }
            UpdateJsonConfigData(_config);
            RefreshConfigData();
        }

        public ConfigModel.PeriodRule GetPeriodRuleByPeriodName(ConfigModel.JsonConfig config, string periodName)
        {
            var period = _config.Period.FirstOrDefault(s => String.Equals(s.PeriodName, periodName, StringComparison.CurrentCultureIgnoreCase));
            return period;
        }
    }
}
