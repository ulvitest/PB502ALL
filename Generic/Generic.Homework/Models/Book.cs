

using Generic.Homework.Exceptions;

namespace Generic.Homework.Models
{
    internal class Book:Product
    {
    

        public Book(string auhtorName, int pageCount,string name,double price,int count)
        {
            AuhtorName = auhtorName;
            PageCount = pageCount;
            Name = name;
            Price = price;
            Count = count;
        }

        public string AuhtorName { get; set; }
        public int PageCount { get; set; }

        

        public override void Sell()
        {
            if (Count > 0)
            {
                Count--;
                TotalInCome += Price;
            }
            else
            {
                throw new ProductCountIsZeroException("kitab bitib");
            }
        }

        public override void ShowInfo()
        {
            Console.WriteLine($"Id: {Id} Name: {Name}");
        }
    }
}
