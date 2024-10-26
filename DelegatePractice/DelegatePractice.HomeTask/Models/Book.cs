using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace DelegatePractice.HomeTask.Models
{
    internal class Book : IEntity
    {
        public static int _id;
        public Book(int pageCount, string authorName, string name)
        {
            _id++;
            Id = _id;
            PageCount = pageCount;
            AuthorName = authorName;
            Name = name;
        }

        public int Id { get; }
        public int PageCount { get; set; }
        public string AuthorName { get; set; }
        public string Name { get; set; }
        public bool IsDelete { get; set; } = false;
        public DateTime CreatedDate { get; set; }
        public void ShowInfo()
        {
            Console.WriteLine($"Name : {Name}");
        }
    }
}
