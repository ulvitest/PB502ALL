

namespace AbstractClassInterface.HomeWork.Models
{
    internal class Book:Product
    {
        public string Genre;

        public override string ToString()
        {
            return Name;
        }
    }
}
