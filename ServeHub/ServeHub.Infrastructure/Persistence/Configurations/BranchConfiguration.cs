using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ServeHub.Domain.Entities;

namespace ServeHub.Infrastructure.Persistence.Configurations
{
    public class BranchConfiguration : IEntityTypeConfiguration<Branch>
    {
        public void Configure(EntityTypeBuilder<Branch> builder)
        {
            builder.ToTable("Branches");

            // ---- Properties ----
            builder.Property(b => b.branchName)
                   .HasMaxLength(100)
                   .IsRequired();

            builder.Property(b => b.branchAddress)
                   .HasMaxLength(500);
                   

            // ---- Indexes ----
            builder.HasIndex(b => b.branchName).IsUnique();

            
        }
    }
}
