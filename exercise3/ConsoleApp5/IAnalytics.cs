using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp5
{
    interface IAnalytics
    {
        double[] CalculateAveragePerColumn(Dataset dataset);
        double[] CalculateAveragePerRow(Dataset dataset);
    }
}
