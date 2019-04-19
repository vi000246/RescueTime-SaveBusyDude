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
            using (StreamReader r = new StreamReader(_jsonFileName))
            {
                string json = r.ReadToEnd();
                ConfigModel.JsonConfig config = ConfigUtil.Deserialize<ConfigModel.JsonConfig>(json);
                if (config != null &&
                    (config.Alert!=null || config.AlertRecord!=null || config.Apikey!=null || config.Focus!=null ||config.Period!=null))
                {
                    this._config = config;
                }
                else
                {
                    //如果抓不到config 就init一個新的
                    UpdateJsonConfigData(new ConfigModel.JsonConfig());
                }

            }
        }

        public ConfigModel.JsonConfig GetJsonConfigData()
        {
            return _config;
        }

        private void UpdateJsonConfigData(ConfigModel.JsonConfig newJsonObj)
        {
            //validation
            //驗證是否有重覆alertName
            var modifiedJsonString = Newtonsoft.Json.JsonConvert.SerializeObject(newJsonObj);
            File.WriteAllText(_jsonFileName, modifiedJsonString);
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
            var OldRuleIndex = _config.Alert.FindIndex(c => c.alertName == alertRule.alertName);
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

                var OldRuleIndex = _config.AlertRecord.FindIndex(c => c.AlertName == alertRecord.AlertName);
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
            var OldRuleIndex = _config.Alert.FindIndex(c => c.alertName == alertName);
            if (OldRuleIndex > -1)
            {
                _config.Alert.RemoveAt(OldRuleIndex);
            }
            else
            {
                MessageBox.Show("找不到指定的Alert規則");
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
                MessageBox.Show("找不到指定的Period規則");
            }
            UpdateJsonConfigData(_config);
            RefreshConfigData();
        }
    }
}
