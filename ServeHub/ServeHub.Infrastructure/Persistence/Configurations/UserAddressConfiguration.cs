using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ServeHub.Domain.Entities;
using ServeHub.Infrastructure.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace ServeHub.Infrastructure.Persistence.Configurations
{
    public class UserAddressConfiguration : IEntityTypeConfiguration<UserAddress>
    {
        public void Configure(EntityTypeBuilder<UserAddress> builder)
        {
            builder.ToTable("UserAddresses");

            // ---- Properties ----
            builder.Property(a => a.address)
                   .HasMaxLength(500)
                   .IsRequired();

            // ---- Relationship to Identity (1:M) ----
            builder.HasOne<ApplicationUser>()
                   .WithMany()
                   .HasForeignKey(a => a.userId)
                   .OnDelete(DeleteBehavior.Cascade);

            // ---- Indexes ----
            builder.HasIndex(a => a.userId);
        }
    }
}
