using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
namespace ConsoleApp5
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
            int columnCount = data[0].Length;  
            double[] results = new double[columnCount];

            for (int j = 0; j < columnCount; j++)  
            {
                double columnSum = 0;

                for (int i = 0; i < rowCount; i++) { 
                    columnSum += data[i][j];
                }

                results[j] = columnSum / rowCount;
            }

            return results;
        }
    }
}

