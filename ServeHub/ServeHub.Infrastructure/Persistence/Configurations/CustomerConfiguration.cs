using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ServeHub.Domain.Entities;
using ServeHub.Infrastructure.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace ServeHub.Infrastructure.Persistence.Configurations
{
    public class CustomerConfiguration : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            builder.ToTable("Customers");

            // ---- Relationship to Identity (1:1) ----
            builder.HasOne<ApplicationUser>()
                   .WithOne()
                   .HasForeignKey<Customer>(c => c.userId)
                   .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
