using ServeHub.Domain.Entities.Common;

namespace ServeHub.Domain.Entities
{
    public class ProductMedia:BaseEntity
    {
        public string mediaUrl { get; private set; }

        public Guid productId { get; private set; }
        public Product? product { get; private set; }

        private ProductMedia()
        { }
    }
}
