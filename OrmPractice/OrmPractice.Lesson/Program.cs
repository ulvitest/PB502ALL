using Microsoft.EntityFrameworkCore;
using OrmPractice.Lesson.Data;
using OrmPractice.Lesson.Entities;

Console.WriteLine("hello");
#region first
//composite primary key
//LINQ METHODS 
//List<int> numbers = new List<int>() { 22, 55, 88, 2, 700 ,2};
//numbers.FindAll(n => n > 10);
//numbers.Where(n => n > 10).OrderBy(n => n).ToList();
//numbers.Distinct().ToList();
//Console.WriteLine(numbers.ElementAt(0));
//foreach (var item in numbers.Select(n => n > 2))
//{
//    Console.WriteLine(item);
//}
#endregion

#region second
//AcademyContext academyContext = new AcademyContext();
//academyContext.Groups.Add(new() { Name = "PB502",Limit= 10 });
//academyContext.SaveChanges();

//academyContext.Groups.AddRange(new() { Name = "PB303", Limit = 12 }, new() { Name = "PB202", Limit = 20 });
//academyContext.SaveChanges();
//var groups=academyContext.Groups
//     .Where(g=>g.Name.Contains("a"))
//     .ToList();
//foreach (var group in groups)
//    Console.WriteLine(group.Id+" "+group.Name+" "+group.Limit);

//var group = academyContext.Groups.Find(1);
//Console.WriteLine(group.Name);
//var group = academyContext.Groups
//    .SingleOrDefault(g => g.Id == 1);

//var group = academyContext.Groups.SingleOrDefault(g => g.Id == 1);
//academyContext.Groups.Remove(group);
//academyContext.SaveChanges();

//var group = academyContext.Groups.SingleOrDefault(g => g.Id == 2);
//group.Name = "PB100";
//group.Limit = 3;
//academyContext.SaveChanges();
//var groups = academyContext.Groups.AsNoTracking().ToList();
//var datas = academyContext.ChangeTracker.Entries();
//Console.WriteLine();

#endregion

//code first
//migrations
AcademyContext context = new AcademyContext();
//var group1 = new Group() { Name = "Pb202", Limit = 10 };
//var group2 = new Group() { Name = "Pb203", Limit = 11 };
//var group3 = new Group() { Name = "Pb205", Limit = 5 };
//context.Groups.AddRange(group1,group2,group3);
//context.SaveChanges();();
//var stu1 = new Student() { Name = "Stu1", GroupId = 1 };
//var stu2 = new Student() { Name = "Stu2", GroupId = 1 };
//var stu3 = new Student() { Name = "Stu3", GroupId = 2 };
//var stu4 = new Student() { Name = "Stu4", GroupId = 2 };
//var stu5 = new Student() { Name = "Stu5", GroupId = 3 };
//context.Students.AddRange(stu1, stu2, stu3, stu4, stu5);
//context.SaveChanges();

//var students = context.Students
//    .Include(s => s.Group)
//    .AsNoTracking().ToList();
//foreach (var student in students)
//    Console.WriteLine(student);
//Console.ReadLine();
//var groups=context.Groups
//    .AsNoTracking()
//    .Include(g=>g.Students)
//    .ToList();
//foreach (var group in groups)
//{
//    Console.WriteLine(group);
//    foreach (var student in group.Students)
//        Console.WriteLine(student);
//    Console.WriteLine("=============");
//}
var details=context.Details
    .AsNoTracking()
    .Include(d=>d.Student)
    .ThenInclude(s=>s.Group)
    .ToList();
Console.WriteLine("");



