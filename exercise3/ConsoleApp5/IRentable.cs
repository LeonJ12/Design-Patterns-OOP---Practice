using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp5
{
    public interface IRentable
    {
        String Description { get; }
        double CalculatePrice();
    }
}
