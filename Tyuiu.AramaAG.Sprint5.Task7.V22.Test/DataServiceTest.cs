using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.AramaAG.Sprint5.Task7.V22.Lib;
using System.IO;

namespace Tyuiu.AramaAG.Sprint5.Task7.V22.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void LoadFromDataFile()
        {
            string path = @"C:\Users\Lenovo\source\repos\Tyuiu.AramaAG.Sprint5\Tyuiu.AramaAG.Sprint5.Task7.V22\bin\Debug\OutPutDataFileTask7V22.txt";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
