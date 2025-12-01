using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp5
{
    class DiscountedItem : RentableDecorator
    {
        public double Discount;
        public DiscountedItem(IRentable r,double discount)
        { 

        }
    }
}
