using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RescueTime_SaveBusyDude.Model
{
    public interface IConfig
    {
        ConfigModel.JsonConfig GetJsonConfigData();
        void InsertUpdateApiKey(string key);
        void InsertUpdateAlertRule(ConfigModel.AlertRule alertRule);
        void InsertUpdateAlertRecord(ConfigModel.AlertRecord alertRecord);
        void InsertUpdateFocusSetting(ConfigModel.FocusSetting setting);
        void InsertUpdatePeriodRule(ConfigModel.PeriodRule periodRule);
        void DeleteAlertRuleByName(string alertName);
        void DeletePeriodRuleByName(string periodName);
    }
}
