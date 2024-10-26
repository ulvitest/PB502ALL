namespace MethodPart2.ClassPractice
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string word = "neyse";

            Student student1=new Student();//instance 
            student1.Age = 20;
            student1.Name = "Asif";
            student1.Address = "Baki";
            student1.PhoneNumber = "111";
            Console.WriteLine(student1.FullInfo());

            



        }
    }
   
   
  

}
