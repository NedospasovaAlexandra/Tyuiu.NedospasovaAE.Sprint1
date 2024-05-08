using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.NedospasovaAE.Sprint1.Task0.V25.Lib;

namespace Tyuiu.NedospasovaAE.Sprint1.Task0.V25.Test
{
    [TestClass]
    public class DaraServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            var res = ds.Calculate();
            Assert.AreEqual(3, res);
        }
    }
}
