using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RelationsExample.Models
{
    internal class StudentDetail
    {
        public int Id { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }

        [ForeignKey(nameof(Student))]
        public int FilankesId { get; set; }
        public Student Student { get; set; }
    }
}
