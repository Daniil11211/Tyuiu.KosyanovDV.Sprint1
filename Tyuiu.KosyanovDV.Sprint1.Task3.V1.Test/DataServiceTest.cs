using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.KosyanovDV.Sprint1.Task3.V1.Lib;

namespace Tyuiu.KosyanovDV.Sprint1.Task3.V1.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckVolume()
        {
            DataService ds = new DataService();
            double r = 1;
            double h = 5;
            double res = ds.CylinderVolume(r, h);
            Assert.AreEqual(15.708, res);
        }
    }
}