
using System.Diagnostics;

namespace AbstractClassInterface.HomeWork.Models
{
    internal class Worker : Person
    {
        public string Profession { get; set; }
        public Worker(string name, string surname, int age, string profession) : base(name, surname, age)
        {
            Profession = profession;
        }

        public override void ShowInfo()
        {
            Console.WriteLine($"Name :{Name} Surname :{SurName} Prof :{Profession}");
        }
        public override string ToString()
        {
            return Profession;
        }
    }
}
