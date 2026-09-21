using ServeHub.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace ServeHub.Domain.Entities
{
    public class Category : BaseEntity
    {
        public string name { get; private set; }
        public string? description { get; private set; }
        public string? imageUrl { get; private set; }
        public bool isActive { get; private set; } = true;
        public Guid? parentCategoryId { get; private set; }
        public Category? parentCategory { get; private set; }

        private readonly List<Category> subCategories = new List<Category>();
        public IReadOnlyCollection<Category> SubCategories => subCategories.AsReadOnly();
        
        private readonly List<Product> products = new List<Product>();
        public IReadOnlyCollection<Product> Products => products.AsReadOnly();
     
        private readonly List<Discount> discounts = new List<Discount>();
        public IReadOnlyCollection<Discount> Discounts => discounts.AsReadOnly();
       
        private readonly List<BranchCategory> branchCategories = new List<BranchCategory>();
        public IReadOnlyCollection<BranchCategory> BranchCategories => branchCategories.AsReadOnly();

        private Category() { }

    }
}
