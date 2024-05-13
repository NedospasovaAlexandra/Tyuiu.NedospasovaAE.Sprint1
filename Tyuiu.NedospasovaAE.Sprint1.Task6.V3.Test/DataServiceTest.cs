using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.NedospasovaAE.Sprint1.Task6.V3.Lib;

namespace Tyuiu.NedospasovaAE.Sprint1.Task6.V3.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidString()
        {
            string strTest = "Привет как дела";
            DataService ds = new DataService();
            string res = ds.LastLetterWord(strTest);
            string wait = "тка";
            Assert.AreEqual(wait, res);
        }
    }
}
