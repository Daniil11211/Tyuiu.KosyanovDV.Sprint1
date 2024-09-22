using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KosyanovDV.Sprint1.Task7.V1.Lib;

namespace Tyuiu.KosyanovDV.Sprint1.Task7.V1.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckExpresion()
        {
            DataService ds = new DataService();
            double x = 1;
            double y = 2;
            double z = 3;
            double res = ds.Calculate(x,y,z);
            Assert.AreEqual(0.250, res);
        }
    }
}