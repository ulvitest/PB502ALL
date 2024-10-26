namespace AbstractClassInterface.HomeWork.Models
{
    internal class Person
    {

        public Person(string name, string surName, int age)
        {
            Name = name;
            SurName = surName;
            Age = age;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string SurName { get; set; }
        public int Age { get; set; }
        public virtual void ShowInfo()
        {
            Console.WriteLine($"Name :{Name} Surname :{SurName}");
        }


    }

}
