using ServeHub.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace ServeHub.Domain.Entities
{
    public class Cart: BaseEntity
    {
        public Guid customerId { get; private set; }
        public Customer? customer { get; private set; }
        private readonly List<CartItem> _cartItems = new List<CartItem>();
        public IReadOnlyCollection<CartItem> cartItems => _cartItems.AsReadOnly();
        
        private Cart() { }

    }
}
