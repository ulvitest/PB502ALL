using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrmPractice.Lesson.Entities
{
    internal class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int? GroupId { get; set; }
        public Group Group { get; set; }
        public override string ToString()
        {
            return Id+" "+Name+" "+Group.Name;
        }
    }
}
