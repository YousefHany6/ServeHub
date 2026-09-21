using ServeHub.Domain.Entities.Common;
using ServeHub.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace ServeHub.Domain.Entities
{
    public class Discount : BaseEntity
    {
        public string name { get; private set; }
        public DiscountType discountType { get; private set; }
        public DiscountScope discountScope { get; private set; }
        public string? promoCode { get; private set; }

        
        public decimal? percentage { get; private set; }
        public decimal? amount { get; private set; }

        public DateOnly startDate { get; private set; }
        public DateOnly endDate { get; private set; }
        public bool isActive { get; private set; } = true;

        
        public Guid? categoryId { get; private set; }
        public Category? category { get; private set; }

        public Guid? productId { get; private set; }
        public Product? product { get; private set; }

        private Discount()
        { }
        }
}

