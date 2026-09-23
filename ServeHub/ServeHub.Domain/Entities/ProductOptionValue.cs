using ServeHub.Domain.Entities.Common;

namespace ServeHub.Domain.Entities
{
    public class ProductOptionValue : BaseEntity
    {
        public string value { get; private set; } 

        public Guid productOptionTypeId { get; private set; }
        public ProductOptionType? productOptionType { get; private set; }

        private readonly List<ProductVariantOptionValue> _productVariantOptionValues = new List<ProductVariantOptionValue>();

        public IReadOnlyCollection<ProductVariantOptionValue> ProductVariantOptionValues => _productVariantOptionValues.AsReadOnly();

        private ProductOptionValue()
        { }
        }
}
