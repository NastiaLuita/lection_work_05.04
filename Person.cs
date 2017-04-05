using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Samost0504
{
    class Person:IComparable<Person>
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public int CompareTo(Person other)
        {
            if (Age > other.Age) return 1;
            else if (Age < other.Age) return -1;
            else return Name.CompareTo(other.Name);
        }

        public override string ToString()
        {
            return Name + ", " + Age.ToString() + " years";
        }
    }
}
