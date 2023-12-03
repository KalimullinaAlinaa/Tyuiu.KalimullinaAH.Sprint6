using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KalimullinaAH.Sprint6.Task0.V3.Lib ;
namespace Tyuiu.KalimullinaAH.Sprint6.Task0.V3.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int x = 3;
            double res = ds.Calculate(x);
            double wait = 4.154;
            Assert.AreEqual(wait, res);
        }
    }
}
