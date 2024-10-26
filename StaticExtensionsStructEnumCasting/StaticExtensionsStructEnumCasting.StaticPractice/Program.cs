using StaticExtensionsStructEnumCasting.StaticPractice.Extensions;
using StaticExtensionsStructEnumCasting.StaticPractice.Models;

namespace StaticExtensionsStructEnumCasting.StaticPractice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //static=>non access modifiers
            // static=>class,all class members,constructor
            //Student student1 = new Student();
            //Console.WriteLine($"student Id {student1.Id}");

            //Student student2 = new Student();
            //Console.WriteLine($"student Id {student2.Id}");

            //Student student3 = new Student();
            //Console.WriteLine($"student Id {student3.Id}");

            //Student student4 = new Student();
            //Console.WriteLine($"student Id {student4.Id}");

            //Console.WriteLine(Student._Id);

            //MyStaticClass myStaticClass = new();

            //Extension =>static class daxilinde static methodlar ile yazilir;
            //string word = "12a";
            //string name = "13a";
            ////word.IsContainsDigit();
            //int num = 5;
            //Console.WriteLine(num.Pow(4));
            Product product1 = new Product() {Id=1, Name = "Iphone11", SalePrice = 11000,CostPrice=500 };//001  s
            Product product2 = new Product() {Id=1, Name = "Iphone11", SalePrice = 11000 , CostPrice = 500 };//002 p
            Product product3 = new Product() {Id=3, Name = "Iphone11", SalePrice = 11000 , CostPrice = 500 };//002 p
            //Console.WriteLine(product1.Equals(product2));

            HashSet<Product> products = new HashSet<Product>(); 
            products.Add(product1);
            products.Add(product2);
            products.Add(product3);
            Console.WriteLine(products.Count);
            






        }
       
    }
}
