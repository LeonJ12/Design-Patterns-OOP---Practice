using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LV2_JL
{
    class Die
    {
        private int numberOfSides;
        private RandomGenerator randomGenerator;
        public Die(int numberOfSides)
        {
            this.numberOfSides = numberOfSides;
            randomGenerator = RandomGenerator.GetInstance();
        }
        public int Roll()
        {
           int rolledNumber = randomGenerator.NextInt(1, numberOfSides + 1);
            return rolledNumber;
        }
        public int GetNumberOfSides()
        {
            return numberOfSides;
        }
    }
    }
