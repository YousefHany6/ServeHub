using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ServeHub.Domain.Entities;

namespace ServeHub.Infrastructure.Persistence.Configurations
{
    public class AreaConfiguration : IEntityTypeConfiguration<Area>
    {
        public void Configure(EntityTypeBuilder<Area> builder)
        {
            builder.ToTable("Areas");

            builder.Property(a => a.name)
                   .HasMaxLength(100)
                   .IsRequired();

            builder.HasOne(a => a.branch)
                   .WithMany(b => b.Areas)
                   .HasForeignKey(a => a.branchId)
                   .OnDelete(DeleteBehavior.Restrict);

            builder.HasIndex(a => new { a.branchId, a.name }).IsUnique();
        }
    }
}

