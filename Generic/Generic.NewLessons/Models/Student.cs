

namespace Generic.NewLessons.Models
{
    internal class Student:BaseEntity,IComparable<Student>
    {

        public string Name { get; set; }

        public int CompareTo(Student? other)
        {
            throw new NotImplementedException();
        }
    }
   
}
