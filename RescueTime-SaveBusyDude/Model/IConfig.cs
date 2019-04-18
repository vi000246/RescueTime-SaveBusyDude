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
        void UpdateJsonConfigData(ConfigModel.JsonConfig newJsonObj);
    }
}
