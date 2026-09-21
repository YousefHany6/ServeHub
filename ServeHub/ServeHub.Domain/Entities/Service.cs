using ServeHub.Domain.Entities.Common;
using ServeHub.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace ServeHub.Domain.Entities
{
    public class Service : BaseEntity
    {
        public string name { get; set; } 
        public ServicePricingType pricingType { get; set; }
        public decimal price { get; set; } 
        public bool isActive { get; set; } = true;

        public Guid branchId { get; set; }
        public Branch? branch { get; set; }

        public ICollection<ServiceUsage>? serviceUsages { get; set; } = new List<ServiceUsage>();
    }
}
