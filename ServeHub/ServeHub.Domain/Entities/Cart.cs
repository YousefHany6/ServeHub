using ServeHub.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace ServeHub.Domain.Entities
{
    public class Cart: BaseEntity
    {
        public string customerId { get; set; }
        public Customer? customer { get; set; }

        public ICollection<CartItem>? cartItems { get; set; } = new List<CartItem>();

    }
}
