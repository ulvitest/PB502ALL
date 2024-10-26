

namespace AbstractClassInterface.NewLessons.Models
{
    internal class DesignEngineer:Engineer
    {
        public string MarkUpLamguage { get; set; }

        public override void Work()
        {
            Console.WriteLine("designer work");
        }
    }
}
