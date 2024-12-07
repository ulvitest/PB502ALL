using Academy.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Academy.DataAccess.Data.Configurations
{
    internal class StudentConfiguration : IEntityTypeConfiguration<Student>
    {
        public void Configure(EntityTypeBuilder<Student> builder)
        {
            builder.Property(s => s.Name).IsRequired(true).HasMaxLength(40);
            builder.Property(s => s.Age).IsRequired(true).HasDefaultValue(15);
            builder.HasOne(s => s.Group).WithMany(g => g.Students).HasForeignKey(s=>s.GroupId).OnDelete(DeleteBehavior.Cascade);
        }
    }
}
