using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LV6_JL
{
    class CareTaker
    {
        private List<Memento> mementos = new List<Memento>();
        

        public Memento GetMemento(int index)
        {
            if (index >= 0 && index < mementos.Count)
            {
                return mementos[index];
            }
            return null;
        }
        public void RemoveMemento(Memento memento)
        {
            mementos.Remove(memento);
        }
        public void AddMemento(Memento memento)
        {
            mementos.Add(memento);
        }
        
    }
}
