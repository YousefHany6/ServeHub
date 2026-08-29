using ServeHub.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace ServeHub.Domain.Entities
{
    public class OrderItem : BaseEntity
    {
        public int quantity { get; set; }
        public decimal priceAtPurchase { get; set; }

        public string orderId { get; set; }
        public Order? order { get; set; }

        public string? productVariantId { get; set; }
        public ProductVariant? productVariant { get; set; }
    }
}
