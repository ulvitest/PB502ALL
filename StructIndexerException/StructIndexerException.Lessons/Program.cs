using StructIndexerException.Lessons.Exceptions;
using StructIndexerException.Lessons.Models;
using StructIndexerException.Library.Implementation;

namespace StructIndexerException.Lessons
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
                Calculate calculate = new Calculate();
                calculate.Divide(10, 0);
          
        }
        static Student[] GetAll()
        {
            Student student1 = new(1, "Senan");
            Student student2 = new(2, "Cavid");
            Student student3= new(3, "Nesib");
            Student student4 = new(4, "Isa");

            return new Student[] { student1, student2, student3, student4 };
        }
        static Student GetStudentById(int id)
        {
            Student[]students = GetAll();
            foreach (var student in students )
            {
                if (student.Id==id)
                {
                    return student;
                }
            }
            throw new StudentNotFoundException($"{id} li telebe tapilmadi");
        }
    }















   
    interface ITest
    {
        void Test();
        public int D { get; set; }
    }

    struct Area:ITest
    {
        public int x;
        public int Y { get; set; }
        public int D { get; set; }

        public Area()
        {
         
        }
       

        public void GetArea()
        {
            Console.WriteLine(x+Y);
        }

        public void Test()
        {
            throw new NotImplementedException();
        }
    }
   
}
