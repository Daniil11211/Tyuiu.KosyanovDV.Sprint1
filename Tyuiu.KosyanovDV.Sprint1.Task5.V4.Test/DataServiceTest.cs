using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KosyanovDV.Sprint1.Task5.V4.Lib;

namespace Tyuiu.KosyanovDV.Sprint1.Task5.V4.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckTime()
        {
            DataService ds = new DataService();
            int x = 16789;
            int res = ds.SecondsToHours(x);
            Assert.AreEqual(4, res);
        }
    }
}