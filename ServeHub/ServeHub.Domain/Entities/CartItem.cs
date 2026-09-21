using ServeHub.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace ServeHub.Domain.Entities
{
    public class CartItem : BaseEntity
    {
        public int quantity { get; set; }

        public Guid cartId { get; set; }
        public Cart? cart { get; set; }

        public string productVariantId { get; set; }
        public ProductVariant? productVariant { get; set; }
    }
}
