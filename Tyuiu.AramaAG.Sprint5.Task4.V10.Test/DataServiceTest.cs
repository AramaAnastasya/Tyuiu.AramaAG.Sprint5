using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.AramaAG.Sprint5.Task4.V10.Lib;
using System.IO;

namespace Tyuiu.AramaAG.Sprint5.Task4.V10.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void LoadFromDataFile()
        {
            string path = @"C:\DataSprint5\InPutDataFileTask4V10.txt";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
