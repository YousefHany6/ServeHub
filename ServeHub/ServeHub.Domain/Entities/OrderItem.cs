using ServeHub.Domain.Entities.Common;

namespace ServeHub.Domain.Entities
{
    public class OrderItem : BaseEntity
    {
        public int quantity { get;private set; }
        public decimal priceAtPurchase { get;private set; }

        public Guid orderId { get;private set; }
        public Order? order { get;private set; }

        public Guid? productVariantId { get;private set; }
        public ProductVariant? productVariant { get;private set; }

        private OrderItem() { }
    }
}
