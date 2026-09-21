using ServeHub.Domain.Entities.Common;
using ServeHub.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace ServeHub.Domain.Entities
{
    public class Service : BaseEntity
    {
        public string name { get; private set; } 
        public ServicePricingType pricingType { get; private set; }
        public decimal price { get; private set; } 
        public bool isActive { get; private set; } = true;

        public Guid branchId { get; private set; }
        public Branch? branch { get; private set; }
        private Service()
        { }

        private readonly List<ServiceUsage> _serviceUsages = new List<ServiceUsage>();
        public IReadOnlyCollection<ServiceUsage> serviceUsages => _serviceUsages.AsReadOnly();
        
    }
}
