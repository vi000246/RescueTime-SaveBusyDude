using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RescueTime_SaveBusyDude.Model
{
    public class JsonBinConfig : IConfig
    {
        public ConfigModel.JsonConfig _config = null;

        public JsonBinConfig()
        {
            RefreshConfigData();
        }

        private void RefreshConfigData()
        {
            this._config = null;
//            using (StreamReader r = new StreamReader(_jsonFileName))
//            {
//                string json = r.ReadToEnd();
//                ConfigModel.JsonConfig config = ConfigUtil.Deserialize<ConfigModel.JsonConfig>(json);
//                this._config = config;
//
//            }
        }

        public ConfigModel.JsonConfig GetJsonConfigData()
        {
            return this._config;
        }
        public ConfigModel.AlertRecord GetAlertRecordByName(string name)
        {
            throw new NotImplementedException();
        }
        private void UpdateJsonConfigData(ConfigModel.JsonConfig newJsonObj)
        {
            throw new NotImplementedException();
        }

        public void InsertUpdateApiKey(string key)
        {
            throw new NotImplementedException();
        }

        public void InsertUpdateAlertRule(ConfigModel.AlertRule alertRule)
        {
            throw new NotImplementedException();
        }

        public void InsertUpdateAlertRecord(ConfigModel.AlertRecord alertRecord)
        {
            throw new NotImplementedException();
        }

        public void InsertUpdateFocusSetting(ConfigModel.FocusSetting setting)
        {
            throw new NotImplementedException();
        }

        public void InsertUpdatePeriodRule(ConfigModel.PeriodRule periodRule)
        {
            throw new NotImplementedException();
        }

        public void DeleteAlertRuleByName(string alertName)
        {
            throw new NotImplementedException();
        }

        public void DeletePeriodRuleByName(string periodName)
        {
            throw new NotImplementedException();
        }
    }
}
