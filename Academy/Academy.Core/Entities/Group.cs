
using System.ComponentModel.DataAnnotations;

namespace Academy.Core.Entities
{
    public class Group:BaseEntity
    {
        [Required]
        [StringLength(10)]
        public string No { get; set; }
        [Range(0, 20)]
        public int Limit { get; set; }
        public DateTime CreatedDate { get; set; }
        public List<Student> Students { get; set; }

        public override string ToString()
        {
            return Id + " " + No + " " + Limit;
        }
    }
}
