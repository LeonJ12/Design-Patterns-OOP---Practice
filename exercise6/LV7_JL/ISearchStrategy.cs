using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LV7_JL
{
    internal interface ISearchStrategy
    {
          bool Contains(double[] number, double target);
    }
}
