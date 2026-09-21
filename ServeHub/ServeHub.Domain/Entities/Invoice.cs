using ServeHub.Domain.Entities.Common;
using ServeHub.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace ServeHub.Domain.Entities
{
    public class Invoice : BaseEntity
    {
        public decimal subtotal { get; set; }
        public decimal discountAmount { get; set; }
        public decimal deliveryFee { get; set; }
        public decimal totalAmount { get; set; }

        public PaymentMethod paymentMethod { get; set; }
        public PaymentStatus paymentStatus { get; set; }
        public string? gatewayTransactionId { get; set; }

       
        public Guid orderId { get; set; }
        public Order? order { get; set; }
    }
}
