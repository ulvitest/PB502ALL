
using Academy.Core.Enums;
using System.ComponentModel.DataAnnotations;

namespace Academy.Core.Entities
{
    public class Student:BaseEntity
    {
        [Required]
        [StringLength(10)]
        public string Name { get; set; }
        [Range(15,40)]
        public int Age { get; set; }
        public int GroupId { get; set; }
        public Group Group { get; set; }
        public PointName GradeName { get; set; }
    }
}
