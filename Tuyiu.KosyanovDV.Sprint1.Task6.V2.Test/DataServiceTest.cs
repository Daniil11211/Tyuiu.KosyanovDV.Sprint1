using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tuyiu.KosyanovDV.Sprint1.Task6.V2.Lib;

namespace Tuyiu.KosyanovDV.Sprint1.Task6.V2.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ÑheckInddexHello()
        {
            DataService ds = new DataService();
            string message = "Hello, world";
            var res = ds.CheckHello(message);
            Assert.AreEqual(true, res);
        }
    }
}