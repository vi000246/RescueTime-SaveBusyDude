using Microsoft.VisualStudio.TestTools.UnitTesting;
using RescueTime_SaveBusyDude;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RescueTime_SaveBusyDude.Tests
{
    [TestClass()]
    public class RescueTimeAPITests
    {
        [TestMethod()]
        public void GetActivityDataByHourTest()
        {
            var res = RescueTimeAPI.GetActivityDataByHour();
            Assert.IsNotNull(res);
        }
    }
}