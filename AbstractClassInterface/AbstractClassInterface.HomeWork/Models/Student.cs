namespace AbstractClassInterface.HomeWork.Models
{
    internal class Student : Person
    {
        public int Grade { get; set; }
        public Student(string name, string surname, int age, int grade) : base(name, surname, age)
        {
            Grade = grade;
        }

        //dynamic polymorphism (runtime) =>override
        public override void ShowInfo()
        {
            Console.WriteLine($"Name :{Name} Surname :{SurName} Grade :{Grade}");
        }
        public override string ToString()
        {
            return Name;
        }



    }
}
