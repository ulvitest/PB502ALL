

namespace StructIndexerException.Lessons.Models
{
    internal class Book
    {
        public string Name { get; set; }
        public string Author { get; set; }
        public override string ToString()
        {
            return Name; 
        }
    }
}
