namespace ServeHub.Domain.Entities
{
    public class ProductVariantOptionValue
    {
        public Guid productVariantId { get;private set; }
        public Guid productOptionValueId { get;private set; }

        public ProductVariant? productVariant { get;private set; }
        public ProductOptionValue? productOptionValue { get;private set; }

        private ProductVariantOptionValue()
        { }

    }
}
