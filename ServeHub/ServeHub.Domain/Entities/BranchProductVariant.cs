using ServeHub.Domain.Constants;
using ServeHub.Domain.Exceptions;

namespace ServeHub.Domain.Entities
{
    public class BranchProductVariant
    {
        public Guid branchId { get; private set; }
        public Guid productVariantId { get; private set; }

       public bool isAvailable { get; private set; } 
        public decimal price { get; private set; }


        public Branch? branch { get; private set; }
        public ProductVariant? productVariant { get; private set; }
        private BranchProductVariant() { }
        internal BranchProductVariant(Guid branchId, Guid productVariantId, bool isAvailable, decimal price)
        {
            if (price <= 0)
            {
                throw new DomainException(DomainErrors.BranchProductVariant.PriceCanNotBeLessThanZeroOrZero);
            }
            this.branchId = branchId;
            this.productVariantId = productVariantId;
            this.isAvailable = isAvailable;
            this.price = price;
        }
    }
}
