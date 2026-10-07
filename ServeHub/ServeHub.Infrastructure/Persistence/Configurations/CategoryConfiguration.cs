using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ServeHub.Domain.Entities;

namespace ServeHub.Infrastructure.Persistence.Configurations
{
    public class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.ToTable("Categories");

            // ---- Properties ----
            builder.Property(c => c.name)
                   .HasMaxLength(150)
                   .IsRequired();

            builder.Property(c => c.description)
                   .HasMaxLength(2000);

            builder.Property(c => c.imageUrl)
                   .HasMaxLength(500);

            // ---- Relationships ----
            // Self-reference (شجرة التصنيفات)
            builder.HasOne(c => c.parentCategory)
                   .WithMany(c => c.SubCategories)
                   .HasForeignKey(c => c.parentCategoryId)
                   .OnDelete(DeleteBehavior.Restrict);
        }
    }
}

