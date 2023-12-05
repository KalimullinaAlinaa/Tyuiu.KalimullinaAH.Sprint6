using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KalimullinaAH.Sprint6.Task4.V28.Lib;
namespace Tyuiu.KalimullinaAH.Sprint6.Task4.V28.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidF()
        {
             DataService ds = new DataService();

            int startValue = -5;
            int stopValue = 5;

            int len = (stopValue - startValue) + 1;
            double[] res = new double[len];
            res = ds.GetMassFunction(startValue, stopValue);

            double[] wait = { -11.22, -8.65, -4.76,-6.47,-2.98, 1, 1.82, 3.55, 6.99, 7.74, 9.03 };
            CollectionAssert.AreEqual(wait, res);
        }
    }
}
