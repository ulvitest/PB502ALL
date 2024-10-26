using System;


namespace Generic.Homework.Models
{
    internal class Person:IComparable<Person>
    {
        public Person(string name, string surName, int age)
        {
            Name = name;
            SurName = surName;
            Age = age;
        }

        public string Name { get; set; }
        public string SurName { get; set; }
        public int Age { get; set; }
       public static Person[] GetPersons()
        {
            Person person1 = new("Cavid", "", 20);
            Person person2 = new("Seymur", "", 15);
            Person person3 = new("Fidan", "", 22);
            Person[] persons = { person1, person2, person3 };
            return persons;
        }

     
        public override string ToString()
        {
            return Age.ToString();
        }

        public int CompareTo(Person? other)
        {
            return Age.CompareTo(other.Age);
        }

        public static bool operator >(Person a, Person b)
        {
            return a.Age>b.Age;
        }
        public static bool operator <(Person a, Person b)
        {
            return a.Age < b.Age;
        }
    }
}
