using Microsoft.EntityFrameworkCore;
using OrmPractice.Lesson.Entities;

namespace OrmPractice.Lesson.Data
{
    internal class AcademyContext:DbContext
    {
        public DbSet<Group> Groups { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Detail> Details { get; set; }
        public DbSet<Teacher> Teachers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-14DGEFO\\SQLEXPRESS;Database=PB502;Trusted_Connection=True;TrustServerCertificate=True");
        }
    }
}
