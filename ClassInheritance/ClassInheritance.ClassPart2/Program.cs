namespace ClassInheritance.ClassPart2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //constructor=>
            //1.class ile eyni adli olur,
            //2.return type yoxdur,
            //3.instance yaradilanda cagirilir;

            Worker worker1 = new Worker("Asif",20);
            worker1.Profession = "Programmer";
            worker1.Surname = "Muxtarov";
            worker1.FullInfo();


            Student student1 = new Student("Yusif",21);
            student1.Surname = "MirXudayev";
            student1.Point = 88;
            student1.FullInfo();

            Product product1 = new Product();

        }
    }
}
