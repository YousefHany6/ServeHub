using System;
using System.Collections.Generic;
using System.Text;

namespace ServeHub.Domain.Entities
{
    public class ProductVariantOptionValue
    {
        public Guid productVariantId { get; set; }
        public Guid productOptionValueId { get; set; }

        public ProductVariant? productVariant { get; set; }
        public ProductOptionValue? productOptionValue { get; set; }
    }
}
