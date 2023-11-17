﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.AramaAG.Sprint5.Task3.V19.Lib;
using System.IO;

namespace Tyuiu.AramaAG.Sprint5.Task3.V19.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckedExistsFile()
        {
            string path = @"C:\Users\Lenovo\source\repos\Tyuiu.AramaAG.Sprint5\Tyuiu.AramaAG.Sprint5.Task3.V19\bin\Debug\OutPutFileTask3.bin";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
