using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.KosyanovDV.Sprint1.Task4.V9.Lib;

namespace Tyuiu.KosyanovDV.Sprint1.Task4.V9.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckExpression()
        {
            DataService ds = new DataService();
            double x = 1;
            double y = 2;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(-1.543, res);
        }
    }
}