using ServeHub.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace ServeHub.Domain.Entities
{
    public class ProductVariant : BaseEntity
    {
        public string sku { get; set; }
       
        public string productId { get; set; }
        public Product? product { get; set; }

        public ICollection<ProductVariantOptionValue>? productVariantOptionValues { get; set; } = new List<ProductVariantOptionValue>();
        public ICollection<CartItem>? cartItems { get; set; } = new List<CartItem>();
        public ICollection<OrderItem>? orderItems { get; set; } = new List<OrderItem>();
        public ICollection<BranchProductVariant>? branchProductVariants { get; set; } = new List<BranchProductVariant>();
    }
}
