using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LV4
{
    class Analyzer3rdParty
    {
        public double[] PerRowAverage(double[][] data)
        {
            int rowCount = data.Length;
            double[] results = new double[rowCount];

            for (int i = 0; i < rowCount; i++)
            {
                results[i] = data[i].Average();
            }
            return results;
        }
        public double[] PerColumnAverage(double[][] data)
        {
            int rowCount = data.Length;
            int columnCount = data.Length;
            double[] results = new double[columnCount];

            for(int j = 0; j < columnCount; j++)
            {
                double sum = 0;
                for(int i = 0; i < rowCount; i++)
                {
                    sum += data[i][j];
                }
                results[j] = data[j].Average();
            }
            return results;
        }
    }
}
