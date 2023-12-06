using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KalimullinaAH.Sprint6.Task5.V14.Lib;
using System.IO;
namespace Tyuiu.KalimullinaAH.Sprint6.Task5.V14.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void Valid()
        {
            DataService ds = new DataService();
            string path = @"C:\DataSprint6\InPutFileTask5V14.txt";

            double[] res = ds.LoadFromDataFile(path);

            double[] wait = { 13,11.49,10,14.52,16,13.66,19,11,11.28 };

            CollectionAssert.AreEqual(wait, res);
        }
    }
}
