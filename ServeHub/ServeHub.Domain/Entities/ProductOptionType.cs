using ServeHub.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace ServeHub.Domain.Entities
{
    public class ProductOptionType : BaseEntity
    {
        public string name { get; set; } 

        public Guid productId { get; set; }
        public Product? product { get; set; }

        public ICollection<ProductOptionValue>? productOptionValues { get; set; } = new List<ProductOptionValue>();
    }
}
