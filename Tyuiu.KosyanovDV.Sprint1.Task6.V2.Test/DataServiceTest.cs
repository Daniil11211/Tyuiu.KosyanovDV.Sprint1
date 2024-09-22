using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KosyanovDV.Sprint1.Task6.V2.Lib;

namespace Tyuiu.KosyanovDV.Sprint1.Task6.V2.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckMessageHello()
        {
            DataService ds = new DataService();
            string stroke = "Hello, my dear friend!";
            bool res = ds.CheckHello(stroke);
            Assert.AreEqual(true, res);
        }
    }
}