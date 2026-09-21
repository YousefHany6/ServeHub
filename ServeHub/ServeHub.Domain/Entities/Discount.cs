using ServeHub.Domain.Entities.Common;
using ServeHub.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace ServeHub.Domain.Entities
{
    public class Discount : BaseEntity
    {
        public string name { get; set; }
        public DiscountType discountType { get; set; }
        public DiscountScope discountScope { get; set; }
        public string? promoCode { get; set; }

        
        public decimal? percentage { get; set; }
        public decimal? amount { get; set; }

        public DateOnly startDate { get; set; }
        public DateOnly endDate { get; set; }
        public bool isActive { get; set; } = true;

        
        public Guid? categoryId { get; set; }
        public Category? category { get; set; }

        public Guid? productId { get; set; }
        public Product? product { get; set; }
    }
}

