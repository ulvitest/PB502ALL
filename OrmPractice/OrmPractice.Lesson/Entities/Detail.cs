﻿

namespace OrmPractice.Lesson.Entities
{
    internal class Detail
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public int StudentId { get; set; }
        public Student Student { get; set; }
    }
}
