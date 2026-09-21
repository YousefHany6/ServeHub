using ServeHub.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace ServeHub.Domain.Entities
{
    public class Product : BaseEntity
    {
        public string name { get; set; }
        public string? description { get; set; }
        public bool isActive { get; set; } = true;

        public Guid categoryId { get; set; }
        public Category? category { get; set; }

        public ICollection<ProductVariant>? productVariants { get; set; } = new List<ProductVariant>();
        public ICollection<ProductOptionType>? productOptionTypes { get; set; } = new List<ProductOptionType>();
        public ICollection<Discount>? discounts { get; set; } = new List<Discount>();
        public ICollection<ProductMedia>? productMedias { get; set; } = new List<ProductMedia>();

        public Guid recordedByEmployeeId { get; set; }
        public Employee? recordedByEmployee { get; set; }
    }
}
