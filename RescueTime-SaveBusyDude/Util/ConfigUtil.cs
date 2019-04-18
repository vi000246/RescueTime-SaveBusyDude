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
        public static ConfigFactory _config = new ConfigFactory(EnumModule.ConfigFileType.Local);

        public static ConfigModel.JsonConfig GetJsonConfigData()
        {
            return _config.GetJsonConfigData();
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
