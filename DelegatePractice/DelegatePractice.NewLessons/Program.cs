using DelegatePractice.NewLessons.Models;

List<Student> students = new List<Student>();
students.Add(new Student() { Id=1,Name="Student1",Age=40});
students.Add(new Student() { Id=2,Name="Student2",Age=30});
students.Add(new Student() { Id=3,Name="Student3",Age=14});
students.Add(new Student() { Id=4,Name="Student4",Age=10});

var newStudents=students.FindAll(delegate(Student x)
{
    return x.Age > 30 && x.Id >= 1;
});
var student = students.Find(delegate (Student s)
{
    return s.Id == 1;
});


