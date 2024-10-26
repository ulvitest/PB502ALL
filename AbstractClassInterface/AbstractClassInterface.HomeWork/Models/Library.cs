using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassInterface.HomeWork.Models
{
    internal class Library : ILibrary
    {
        public string Name { get; set; }
        public Book[] Books;
        public Library()
        {
            Books = new Book[0];
        }

        public void AddBook(Book book)//{1,2,0}
        {
            Array.Resize(ref Books, Books.Length + 1);
            Books[Books.Length - 1] = book;
            Console.WriteLine(book.Name + " " + "elave edildi...");
            Console.WriteLine("========================");
        }

        public Book FindBookByName(string name)
        {
            foreach (var book in Books)
            {
                if (book.Name.Equals(name, StringComparison.OrdinalIgnoreCase)) return book;
            }
            return null;
        }
        private int FindBookIndex(string name)
        {
            for (int i = 0; i < Books.Length; i++)
            {
                if (Books[i].Name.Equals(name, StringComparison.OrdinalIgnoreCase)) return i;
            }
            return -1;
        }
        public void ShowAll()
        {
            Console.WriteLine("Book list :");
            foreach (var book in Books)
            {
                Console.WriteLine(book);
            }
            Console.WriteLine("========================");
        }

        public bool RemoveBookByName(string name)
        {
            int index = FindBookIndex(name);
            if (index != -1)
            {
                //{22,5,12}
                var temp = Books[index];
                Books[index] = Books[Books.Length - 1];
                Books[Books.Length - 1] = temp;
                Array.Resize(ref Books, Books.Length - 1);
                return true;
            }
            return false;
        }

        public void SearchForBooks(string search)
        {
            foreach (var book in Books)
            {
                if (book.Name.ToLower().Contains(search.ToLower()))
                {
                    Console.WriteLine(book);
                }
            }
        }
    }
}
