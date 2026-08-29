using ServeHub.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace ServeHub.Domain.Entities
{
    public class ProductOptionValue : BaseEntity
    {
        public string value { get; set; } 

        public string productOptionTypeId { get; set; }
        public ProductOptionType? productOptionType { get; set; }

        public ICollection<ProductVariantOptionValue>? productVariantOptionValues { get; set; } = new List<ProductVariantOptionValue>();
    }
}
