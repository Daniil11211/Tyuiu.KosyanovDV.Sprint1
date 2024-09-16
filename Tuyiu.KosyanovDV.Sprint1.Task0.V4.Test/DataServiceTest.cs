using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tuyiu.KosyanovDV.Sprint1.Task0.V4.Lib;

namespace Tuyiu.KosyanovDV.Sprint1.Task0.V4.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void validExpression()
        {
            DataService ds = new DataService();
            var res = ds.Calculate();
            Assert.AreEqual(2, res);
        }
    }
}