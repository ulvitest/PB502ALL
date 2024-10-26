
using System.Collections;

namespace StructIndexerException.Lessons.Models
{
    internal class Student:IComparable<Student>
    {
        public Student(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public static bool operator >(Student a,Student b)
        {
            return a.Id > b.Id;
        }
        public static bool operator <(Student a, Student b)
        {
            return a.Id < b.Id;
        }
        public static bool operator ==(Student a, Student b)
        {
            return a.Name.Length == b.Name.Length;
        }
        public static bool operator !=(Student a, Student b)
        {
            return a.Id != b.Id;
        }

        public override bool Equals(object? obj)
        {
            if(obj == null|| obj is not Student)
                return false;

            Student student = obj as Student;
            return Name.Equals(student.Name);
        }
        public override string ToString()
        {
            return Name;
        }

        public int CompareTo(Student? other)
        {
            if (other == null) return -1;
             return Id.CompareTo(other.Id);
        
        }

   
    }
}
