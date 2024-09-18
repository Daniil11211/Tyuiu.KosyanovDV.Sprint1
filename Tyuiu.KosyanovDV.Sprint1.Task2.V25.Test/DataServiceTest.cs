using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using Tyuiu.KosyanovDV.Sprint1.Task2.V25.Lib;

namespace Tyuiu.KosyanovDV.Sprint1.Task2.V25.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            int x = 2;
            double res = ds.ConvertRadsToDegrees(x);
            Assert.AreEqual(114.592, res);
        }
    }
}