using System;
using System.Collections.Generic;
using System.Text;

namespace ServeHub.Domain.Entities
{
    public class ProductVariantOptionValue
    {
        public string productVariantId { get; set; }
        public string productOptionValueId { get; set; }

        public ProductVariant? productVariant { get; set; }
        public ProductOptionValue? productOptionValue { get; set; }
    }
}
