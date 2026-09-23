using ServeHub.Domain.Entities.Common;

namespace ServeHub.Domain.Entities
{
    public class Product : BaseEntity
    {
        public string name { get; private set; }
        public string? description { get; private set; }
        public bool isActive { get; private set; } = true;

        public Guid categoryId { get; private set; }
        public Category? category { get; private set; }

        private Product() { }

        private readonly List<ProductVariant> _productVariants = new List<ProductVariant>();
        public IReadOnlyCollection<ProductVariant> productVariants => _productVariants.AsReadOnly();

        private readonly List<ProductOptionType> _productOptionTypes = new List<ProductOptionType>();
        public IReadOnlyCollection<ProductOptionType> productOptionTypes => _productOptionTypes.AsReadOnly();
        private readonly List<Discount> _discounts = new List<Discount>();
        public IReadOnlyCollection<Discount> discounts => _discounts.AsReadOnly();

        private readonly List<ProductMedia> _productMedias = new List<ProductMedia>();
        public IReadOnlyCollection<ProductMedia> productMedias => _productMedias.AsReadOnly();

        public Guid recordedByEmployeeId { get; private set; }
        public Employee? recordedByEmployee { get; private set; }
    }
}
