
using Academy.Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace Academy.DataAccess.Data
{
    public class AcademyContext:DbContext
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<Group> Groups { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-14DGEFO\\SQLEXPRESS;Database=PB502AcademyDb;Trusted_Connection=True;TrustServerCertificate=True;");
        }
    }
}
