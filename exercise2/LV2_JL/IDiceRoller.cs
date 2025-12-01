using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LV2_JL
{
    interface IDiceRoller
    {
        void InsertDie(Die die);
        void RemoveAllDice();
        void RollAllDice();

    }
}
