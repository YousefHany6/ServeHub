using ServeHub.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace ServeHub.Domain.Entities
{
    public class Category : BaseEntity
    {
        public string name { get; set; }
        public string? description { get; set; }
        public string? imageUrl { get; set; }
        public bool isActive { get; set; } = true;

        
        public Guid? parentCategoryId { get; set; }
        public Category? parentCategory { get; set; }
        public ICollection<Category>? subCategories { get; set; } = new List<Category>();

        public ICollection<Product>? products { get; set; } = new List<Product>();
        public ICollection<Discount>? discounts { get; set; } = new List<Discount>();

        public ICollection<BranchCategory>? branchCategories { get; set; } = new List<BranchCategory>();
    }
}
