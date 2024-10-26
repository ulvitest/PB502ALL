

namespace AbstractClassInterface.NewLessons.Models
{
    internal abstract class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
      
        public abstract void Work();

        public virtual void Detail()
        {
            Console.WriteLine($"Name: {Name} Surname: {Surname}");
        }
    }
}
