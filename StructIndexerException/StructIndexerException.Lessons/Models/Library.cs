
namespace StructIndexerException.Lessons.Models
{
    internal class Library
    {
        public string  Name { get; set; }
        private Book[] _books;
        public Library(int size)
        {
            _books = new Book[size];
        }

        public Book this[int index]
        {
            get
            {
                if (index < 0 || index > _books.Length - 1)
                {
                    Console.WriteLine("xeta bash verdi..");
                    throw new Exception();
                }

                return _books[index];
            }
            set
            {
                if (index < 0 || index > _books.Length - 1)
                {
                    Console.WriteLine("xeta bash verdi..");
                    return;
                }
               _books[index] = value;
            }
        }
    }
}
