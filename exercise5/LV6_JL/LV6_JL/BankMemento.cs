using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LV6_JL
{
    internal class BankMemento
    {
     
        public string OwnerName { get; private set; }
        public string OwnerAddress { get; private set; }
        public decimal Balance { get; private set; }
     
        public BankMemento(string ownername,string owneraddress, decimal balance)
        {
            this.OwnerName = ownername;
            this.OwnerAddress = owneraddress;
            this.Balance = balance;
        }
    }
}
