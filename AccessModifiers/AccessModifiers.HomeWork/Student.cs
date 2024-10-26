namespace AccessModifiers.HomeWork
{
    internal class Student
    {
        //Fullname, BirthDate, GroupNo, Point xüsusiyyətlərinə və ShowInfo metoduna sahib 
        //fields
        public string FullName;
        public string GroupNo;
        public DateTime BirthDay;
        public double Point;

        public Student(string fullName, double point)
        {
            FullName = fullName;
            Point = point;
        }

        public void ShowInfo()
        {
            Console.WriteLine($"FullName :{FullName} BirthDay :{BirthDay.ToString("dddd, dd MMMM yyyy")}");
        }
    }
}
