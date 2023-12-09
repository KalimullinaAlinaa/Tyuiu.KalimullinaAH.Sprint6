using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KalimullinaAH.Sprint6.Task6.V24.Lib;
namespace Tyuiu.KalimullinaAH.Sprint6.Task6.V24.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestCollectTextFromFile()
        {
            DataService ds = new DataService();
            string path = @"C:\DataSprint6\InPutFileTask6V21.txt";
            string str = "";
            string wait = "";
            string res = ds.CollectTextFromFile(str, path);
            Assert.AreEqual(wait, res);
        }
    }
}
