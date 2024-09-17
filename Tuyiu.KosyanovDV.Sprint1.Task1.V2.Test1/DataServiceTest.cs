using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tuyiu.KosyanovDV.Sprint1.Task1.V2.Lib;

namespace Tuyiu.KosyanovDV.Sprint1.Task1.V2.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 3.0;
            double y = 1.0;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(0.375, res);
        }
    }
}