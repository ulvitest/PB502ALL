using SqlConnectionPractice.Services;

namespace SqlConnectionPractice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StudentService studentService = new StudentService();
            //studentService.Create(new() { Name = "Asif", Age = 25 });
            //foreach (var student in studentService.GetAllFromView())
            //    Console.WriteLine(student);
            //Console.WriteLine(studentService.GetNameFromView());
            //Console.WriteLine(studentService.GetById(1));
            //studentService.Delete(2);
            //studentService.Update(1, new() { Name="Yusif",Age=50});
            //Console.WriteLine(studentService.GetDataCount());
            studentService.GetDataWithAge(20);
        }
    }
}
