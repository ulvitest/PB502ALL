using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassInheritance.ClassPart2
{
    internal class Human
    {
        public string Name;
        public string Surname;
        public int Age;
        public Human(string name,int age)
        {
            Name= name;
            Age= age;
        }
        public void Info()
        {
            Console.WriteLine($"{Name} {Surname}");
        }
        public void FullInfo()
        {
            Console.WriteLine($"{Name} {Surname} {Age} ");
        }
    }
}
