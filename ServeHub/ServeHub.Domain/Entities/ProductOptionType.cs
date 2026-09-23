using ServeHub.Domain.Entities.Common;

namespace ServeHub.Domain.Entities
{
    public class ProductOptionType : BaseEntity
    {
        public string name { get; private set; } 

        public Guid productId { get; private set; }
        public Product? product { get; private set; }

        private readonly List<ProductOptionValue> _productOptionValues = new List<ProductOptionValue>();
        public IReadOnlyCollection<ProductOptionValue> ProductOptionValues => _productOptionValues.AsReadOnly();
        private ProductOptionType()
        { }
    }
}
