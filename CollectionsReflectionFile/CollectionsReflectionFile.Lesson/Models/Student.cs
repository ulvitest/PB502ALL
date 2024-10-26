using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Markup;

namespace CollectionsReflectionFile.Lesson.Models
{
    
    public class Student
    {
        private int Point;
        public Student()
        {
            
        }
        public Student(int ıd, string name)
        {
            Id = ıd;
            Name = name;
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public override string ToString()
        {
            return Id+" "+Name;
        }

        public void Info()
        {
            Console.WriteLine(Id+" "+Name);
        }
        
    }
}
