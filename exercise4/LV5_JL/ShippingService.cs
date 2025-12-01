using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LV5_JL
{
    public class ShippingService
    {
        private double UnitPrice;
        public ShippingService(double unitPrice)
        {
            this.UnitPrice = unitPrice;
        }
        public double CalculateShippingCost(IShipable package)
        {
            return package.Weight * UnitPrice;
        }
    }
}
