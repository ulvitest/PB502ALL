using AbstractClassInterface.HomeWork.Models;
using System.Threading.Channels;

namespace AbstractClassInterface.HomeWork
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Library library = new Library();
            library.Name = "Kitabxana A";
            library.Books = new Book[]
            {
                new Book() {Name="Kitab11" },
                new Book() {Name="Book23" },
                new Book() {Name="kitab" },
            };

            string opt;
            do
            {
                ShowMenu();
                opt = Console.ReadLine();

                switch (opt)
                {
                    case "1":
                        var existBook = library.FindBookByName("Book13");
                        if (existBook==null)
                            library.AddBook(new Book { Name = "Book13" });
                        else
                            Console.WriteLine("eyni adli kitab var..");
                        break;
                        case "2":
                        Console.WriteLine("silmek istediyiniz kitabin adini daxil edin :");
                        string targetName=Console.ReadLine();
                        if (library.RemoveBookByName(targetName))
                            Console.WriteLine("silindi");
                        else
                            Console.WriteLine("movcud deyil..");

                        break;
                        case "3":
                        library.ShowAll();
                        break;
                        case "4":
                        Console.WriteLine("tapmaq istediyiniz kitabin adini daxil edin :");
                        string searchedBookName = Console.ReadLine();
                        if (library.FindBookByName(searchedBookName) == null)
                            Console.WriteLine("tapilmadi");
                        else
                        {
                            Console.WriteLine(searchedBookName + " "+"tapildi..");
                        }
                        break;
                        case "5":
                        Console.WriteLine("search edin :");
                        string searchValue=Console.ReadLine();
                        library.SearchForBooks(searchValue);
                        break;
                    default:
                       
                        Console.WriteLine("duzgun secim ele...");
                        break;
                }

            } while (opt!="0");

        }
        static void ShowMenu()
        {
            Console.WriteLine("Menu :");
            Console.WriteLine("1.Kitab elave et :");
            Console.WriteLine("2.Kitab sil");
            Console.WriteLine("3.Kitablara bax");
            Console.WriteLine("4.Secilmis Kitablara bax");
            Console.WriteLine("5.Search");
            Console.WriteLine("0.Exit");
        }
    }

   
}
