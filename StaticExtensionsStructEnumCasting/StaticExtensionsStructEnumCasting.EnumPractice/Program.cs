using StaticExtensionsStructEnumCasting.EnumPractice.Enum;
using StaticExtensionsStructEnumCasting.EnumPractice.Models;

namespace StaticExtensionsStructEnumCasting.EnumPractice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //enum 
            int day=int.Parse(Console.ReadLine());
            switch (day)
            {
                case (int)WeekDays.Monday:
                case (int)WeekDays.Tuesday:
                    Console.WriteLine("1 ve ya 2cigun");
                    break;
                case 3:
                    Console.WriteLine("3ci gun");
                    break;
                case 4:
                    Console.WriteLine("4ci gun");
                    break;
                case 5:
                    Console.WriteLine("5ci gun");
                    break;
                case 6:
                    Console.WriteLine("6ci gun");
                    break;
                case 7:
                    Console.WriteLine("7ci gun");
                    break;
                default:
                    Console.WriteLine("duzgun gun daxil et");
                    break;
            }

            Order order1= new Order();
            order1.No = 100;
            order1.Name = "Pizza";
            order1.UserName = "Filankes";
            order1.CreatedDate= DateTime.Now;
            order1.Status = OrderStatus.Pending;
        }
    }
   
}
