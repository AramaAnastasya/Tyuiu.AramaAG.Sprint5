using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.AramaAG.Sprint5.Task4.V10.Lib
{
    public class DataService : ISprint5Task4V10
    {
        public double LoadFromDataFile(string path)
        {
            string srtX = File.ReadAllText(path);

            double res = Math.Pow(Convert.ToDouble(srtX), 3) * 1.2 * Convert.ToDouble(srtX) + 2.0;

            return Math.Round(res, 3);
        }
    }
}
