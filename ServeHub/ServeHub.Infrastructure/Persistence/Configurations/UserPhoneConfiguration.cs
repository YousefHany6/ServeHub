using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ServeHub.Domain.Entities;
using ServeHub.Infrastructure.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace ServeHub.Infrastructure.Persistence.Configurations
{
    public class UserPhoneConfiguration : IEntityTypeConfiguration<UserPhone>
    {
        public void Configure(EntityTypeBuilder<UserPhone> builder)
        {
            builder.ToTable("UserPhones");

            // ---- Properties ----
            builder.Property(p => p.phone)
                   .HasMaxLength(11)
                   .IsRequired();

            // ---- Relationship to Identity (1:M) ----
            builder.HasOne<ApplicationUser>()
                   .WithMany()
                   .HasForeignKey(p => p.userId)
                   .OnDelete(DeleteBehavior.Cascade);

            // ---- Indexes ----
            builder.HasIndex(p => p.userId);
            builder.HasIndex(p => p.phone).IsUnique();
        }
    }
}

