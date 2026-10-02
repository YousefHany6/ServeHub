using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ServeHub.Domain.Entities;
using ServeHub.Infrastructure.Identity;

namespace ServeHub.Infrastructure.Persistence.Configurations
{
    public class EmployeeConfiguration : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder.ToTable("Employees");

           
            builder.HasOne<ApplicationUser>()
                   .WithOne()
                   .HasForeignKey<Employee>(e => e.userId)
                   .OnDelete(DeleteBehavior.Restrict);
        }
    }
}

