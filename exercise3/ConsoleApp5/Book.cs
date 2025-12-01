using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp5
{
    class Book : IRentable
    {
        private readonly double baseBookPrice = 3.99;
        public string Name { get; private set; }
        public Book(string name)
        {
            this.Name = name;
        }
        public string Description
        {
            get { return this.Name; }
        }
        public double CalculatePrice()
        {
            return baseBookPrice;
        }
    }
}
