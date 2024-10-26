namespace MethodPart2.ClassPractice
{
    class Student
    {
        //fields
        public int Age;
        public string Name;
        public string Address;
        public string PhoneNumber;

        //method
        public string Info()
        {
           return $"Name: {Name} Age :{Age}";
        }
        public string FullInfo()
        {
           return $"{Info()} Address {Address} Phone {PhoneNumber}";
        }



    }
}
