using Generic.Homework.Enums;
using Generic.Homework.Models;

namespace Generic.Homework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //var persons= Person.GetPersons();
            //Array.Sort(persons);
            //foreach (var person in persons)
            //    Console.WriteLine(person);

            //Person person1 = new("Cavid", "", 20);
            //Person person2 = new("Seymur", "", 15);
            //Console.WriteLine(person1>person2);
            //ExChange(Currency.Usd,340);

            Book book = new Book("Test", 200, "Book",price: 10,count:10);
            book.ShowInfo();

            Book book2 = new Book("Test", 200, "Book", price: 10, count: 10);
            book2.ShowInfo();

            //book.Sell();
            //book.Sell();
            //book.Sell();
            //Console.WriteLine(book.TotalInCome);
            //Console.WriteLine(book.Count);

        }
        public static void ExChange(Enum currency ,double azn)
        {
            double result = 0;
            if (currency is Currency c)
            {
                switch (c)
                {

                    case Currency.Usd:
                        result = azn / 1.7;
                        break;
                    case Currency.Eur:
                        break;
                    case Currency.Try:
                        break;
                    default:
                        break;
                }
                Console.WriteLine($"total amount is {result} $");
            }
            else
            {
                Console.WriteLine("duzgun enum (currency) gonder...");
            }

        }
       
    }
   
}
