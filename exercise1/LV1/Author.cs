using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LV1
{
    public class Author
    {
        public string Name { get; private set; }
        public string Surname { get; private set; }
        public DateOnly BirthDate { get; private set; }

        public Author(string name, string surname, DateOnly birthDate)
        {
            Name = name;
            Surname = surname;
            BirthDate = birthDate;
        }
    
        public override string ToString()
        {
            return $"{Name} {Surname} {BirthDate}";
        }
    }
}
