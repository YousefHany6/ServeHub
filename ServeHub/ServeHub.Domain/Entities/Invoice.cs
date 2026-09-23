using ServeHub.Domain.Entities.Common;
using ServeHub.Domain.Enums;

namespace ServeHub.Domain.Entities
{
    public class Invoice : BaseEntity
    {
        public decimal subtotal { get; private set; }
        public decimal discountAmount { get; private set; }
        public decimal deliveryFee { get; private set; }
        public decimal totalAmount { get; private set; }

        public PaymentMethod paymentMethod { get; private set; }
        public PaymentStatus paymentStatus { get; private set; }
        public string? gatewayTransactionId { get; private set; }

       
        public Guid orderId { get; private set; }
        public Order? order { get; private set; }

        private Invoice() { }
    }
}
