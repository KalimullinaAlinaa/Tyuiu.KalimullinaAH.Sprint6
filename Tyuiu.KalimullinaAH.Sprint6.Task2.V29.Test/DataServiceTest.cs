using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KalimullinaAH.Sprint6.Task2.V29.Lib;
namespace Tyuiu.KalimullinaAH.Sprint6.Task2.V29.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMassF()
        {
            DataService ds = new DataService();
            int startValue = -5;
            int stopValue = 5;

            double[] valueWaitArray = new double[stopValue - startValue + 1];


            valueWaitArray[0] = 28.05;
            valueWaitArray[1] = 22.27;
            valueWaitArray[2] = 17.01;
            valueWaitArray[3] = 12.35;
            valueWaitArray[4] = 7.51;
            valueWaitArray[5] = 0;
            valueWaitArray[6] = 1.62;
            valueWaitArray[7] = -7.03;
            valueWaitArray[8] = -12.99;
            valueWaitArray[9] = -17.55;
            valueWaitArray[10] = -21.43;

            double[] res = new double[stopValue - startValue + 1];
            res = ds.GetMassFunction(startValue, stopValue);
            CollectionAssert.AreEqual(valueWaitArray, res);
        }
    }
}
