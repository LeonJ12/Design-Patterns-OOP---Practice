using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LV5_JL
{
    public class Box : IShipable
    {
        private List<IShipable> items;
        private string name;
        public Box(string name)
        {
            this.items = new List<IShipable>();
            this.name = name;
        }
        public void Add(IShipable item)
        {
            this.items.Add(item);
        }
        public void Remove(IShipable item)
        {
            this.items.Remove(item);
        }
        public double Weight
        {
            get
            {
                double TotalWeight = 0;
                foreach (IShipable item in items)
                {
                    TotalWeight += item.Weight;
                }
                return TotalWeight;
            }
        }
        public double Price
        {
            get
            {
                double totalPrice = 0;
                foreach (IShipable item in items)
                {
                    totalPrice += item.Price;
                }
                return totalPrice;
            }
        }
        public string Description(int depth = 0)
        {
            StringBuilder builder =
           new StringBuilder(new string(' ', depth) + this.name + "\n");
            foreach (IShipable item in items)
            {
                builder.Append(item.Description(depth + 2)).Append("\n");
            }
            return builder.ToString();
        }
      
    }
}
