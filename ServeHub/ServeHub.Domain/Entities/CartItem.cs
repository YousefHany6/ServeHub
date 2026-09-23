using ServeHub.Domain.Entities.Common;

namespace ServeHub.Domain.Entities
{
    public class CartItem : BaseEntity
    {
        public int quantity { get; private set; }

        public Guid cartId { get; private set; }
        public Cart? cart { get; private set; }

        public string productVariantId { get; private set; }
        public ProductVariant? productVariant { get; private set; }

        private CartItem() { }
    }
}
