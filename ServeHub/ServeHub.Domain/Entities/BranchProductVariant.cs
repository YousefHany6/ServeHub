using System;
using System.Collections.Generic;
using System.Text;

namespace ServeHub.Domain.Entities
{
    public class BranchProductVariant
    {
        public string branchId { get; set; }
        public string productVariantId { get; set; }

        
        public int stock { get; set; }
        public decimal price { get; set; }


        public int minStockLevel { get; set; }

        public Branch? branch { get; set; }
        public ProductVariant? productVariant { get; set; }
    }
}
