using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.NedospasovaAE.Sprint1.Task5.V7.Lib;

namespace Tyuiu.NedospasovaAE.Sprint1.Task5.V7.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double f = 90;
            int wait = 3;
            double res = ds.AngleToHoursMinutes(f);
            int result = Convert.ToInt32(res);
            Assert.AreEqual(wait, result);
        }
    }
}
