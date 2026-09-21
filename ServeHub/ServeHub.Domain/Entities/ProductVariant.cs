using ServeHub.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace ServeHub.Domain.Entities
{
    public class ProductVariant : BaseEntity
    {
        public Guid productId { get; private set; }
        public Product? product { get; private set; }
        private readonly List<ProductVariantOptionValue> _productVariantOptionValues = new List<ProductVariantOptionValue>();
        public IReadOnlyCollection<ProductVariantOptionValue> ProductVariantOptionValues => _productVariantOptionValues.AsReadOnly();

         private readonly List<CartItem> _cartItems = new List<CartItem>();
        public IReadOnlyCollection<CartItem> CartItems => _cartItems.AsReadOnly();

        private readonly List<OrderItem> _orderItems = new List<OrderItem>();

        public IReadOnlyCollection<OrderItem> OrderItems => _orderItems.AsReadOnly();
      
        private readonly List<BranchProductVariant> _branchProductVariants = new List<BranchProductVariant>();

        public IReadOnlyCollection<BranchProductVariant> BranchProductVariants => _branchProductVariants.AsReadOnly();

        private ProductVariant() { }

    }
}
