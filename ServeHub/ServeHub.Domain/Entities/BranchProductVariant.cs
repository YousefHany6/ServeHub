using ServeHub.Domain.Constants;
using ServeHub.Domain.Exceptions;
using System;
using System.Collections.Generic;
using System.Text;

namespace ServeHub.Domain.Entities
{
    public class BranchProductVariant
    {
        public string branchId { get; private set; }
        public string productVariantId { get; private set; }

       public bool isAvailable { get; private set; } 
        public decimal price { get; private set; }


        public Branch? branch { get; private set; }
        public ProductVariant? productVariant { get; private set; }
        private BranchProductVariant() { }
        internal BranchProductVariant(string branchId, string productVariantId, bool isAvailable, decimal price)
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
