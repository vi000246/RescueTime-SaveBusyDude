using Microsoft.VisualStudio.TestTools.UnitTesting;
using RescueTime_SaveBusyDude.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RescueTime_SaveBusyDude.Model.Tests
{
    [TestClass()]
    public class LocalJsonConfigTests
    {
        [TestMethod()]
        public void UpdateJsonConfigDataTest()
        {
            var config = ConfigUtil.GetJsonConfigData();
            config.Alert.Add(new ConfigModel.AlertRule()
            {
                Hour = 10,AlertType = EnumModule.AlertType.SpecificCategory,PeriodName = new string[]{ "AllDay" }
            });
            var newConfig = ConfigUtil.UpdateJsonConfig(config);
            Assert.IsTrue(newConfig.Alert.Count(x => x.Hour == 10) > 0);
        }

        [TestMethod()]
        public void TestRemoveItem()
        {
            var config = ConfigUtil.GetJsonConfigData();
            config.Alert.Remove(config.Alert[1]);
            var newConfig = ConfigUtil.UpdateJsonConfig(config);
        }
    }
}