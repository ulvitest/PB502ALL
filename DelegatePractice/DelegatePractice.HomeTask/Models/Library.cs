

using System.Security.Cryptography;
using Utils.Exceptions;

namespace DelegatePractice.HomeTask.Models
{
    internal class Library : IEntity
    {
        public static int _id;
        public int Id { get; }
        public int BookLimit { get; set; }
        public List<Book> Books { get; set; }
        public Library()
        {
            _id++;
            Id = _id;
            Books = new();
        }

        public void AddBook(Book book)//book1
        {
            if (Books.Any(b => b.Name==book.Name&& b.IsDelete==false))
                throw new AlreadyExistsException("");

            if (Books.Count >= BookLimit)
                throw new CapacityLimitException("");
            Books.Add(book);
        }
        public Book GetBookId(int? id)
        {
            if(id== null) throw new NullReferenceException("");
            if (Books.Any(b => b.Id==id&& b.IsDelete == false))
                return Books.Find(b => b.Id == id && b.IsDelete == false);
            return null;
        }
        public List<Book> GetAll() => Books.FindAll(b => b.IsDelete == false);
        public void RemoveBookById(int? id)
        {
            var existBook=GetBookId(id);
            if (existBook != null)
                existBook.IsDelete = true;
            else
                throw new NotFoundException("");
        }
        public void UpdateBookById(int? id,string name)//1,test
        {
            var existBook = GetBookId(id);
            if (existBook != null)
                existBook.Name = name;
            throw new NotFoundException("");
        }
        public List<Book> FilterByPageCount(int minPageCount,int maxPageCount) 
            => 
            Books.FindAll(b => b.IsDelete == false&&b.PageCount>minPageCount&&b.PageCount<maxPageCount);

        //CRUD
    }
}
