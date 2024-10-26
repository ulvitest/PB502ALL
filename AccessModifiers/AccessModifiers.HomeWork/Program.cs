using System.Security;

namespace AccessModifiers.HomeWork
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region firstTask

            //Console.WriteLine(10.22.ToString());//false
            //Console.WriteLine("enter student name: ");
            //string fullName = Console.ReadLine();

            //Console.WriteLine("enter student point: ");
            //double point = Convert.ToDouble(Console.ReadLine());

            //Student student = new Student(fullName, point);
            //student.GroupNo = "PB502";
            //student.BirthDay = DateTime.Parse(Console.ReadLine());
            //student.ShowInfo();
            ////class members:fields,methodlar,propertyler
            #endregion
            #region secondTask
            //Console.WriteLine("uzunluq sec :");
            //int result;
            //bool isSuccess=int.TryParse("12", out result);
            //if (isSuccess)
            //{
            //    Product[] products = new Product[result];
            //    for (int i = 0; i < result; i++)
            //    {
            //        Console.WriteLine("product adini daxil et :");
            //        string name = Console.ReadLine();
            //        Product product = new(name);
            //        Console.WriteLine("product price daxil et");
            //        product.Price = double.Parse(Console.ReadLine());
            //        products[i] = product;
            //        Console.WriteLine($"{i+1}ci product elave edildi");
            //    }
            //    double sumOfPrice = 0;
            //    foreach (var product in products)
            //    {
            //       sumOfPrice += product.Price;
            //    }
            //    Console.WriteLine(sumOfPrice/products.Length);
            //}
            //else
            //{
            //    Console.WriteLine("duzgun daxil et");
            //}
            #endregion 
            
            TechStore techStore = new TechStore(0, "TechStore");
            techStore.Add(new NoteBook("T1", 100, 8));
            techStore.Add(new NoteBook("T2", 120, 16));
            techStore.Add(new NoteBook("T3", 120, 16));

            //Console.WriteLine("products list : ");
            //techStore.ShowAll();
            Console.WriteLine(techStore.Find("m1"));




        }
    }
}
