

namespace AbstractClassInterface.NewLessons.Models
{
    internal class ProgrammerEngineer:Engineer
    {
        public  string Language { get; set; }
        public  override void Detail()
        {
            Console.WriteLine($"Name: {Name} Surname: {Surname} Lan: {Language}");
        }

        public override void Work()
        {
            Console.WriteLine("prog engineer work");
        }
    }
}

