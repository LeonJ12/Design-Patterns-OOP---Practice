using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LV7_JL
{
    internal class LinearSearch : ISearchStrategy
    {
        public bool Contains(double[] numbers, double target)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] == target)
                {
                    return true;
                    
                }
            }
            return false;
        }
    }
}
