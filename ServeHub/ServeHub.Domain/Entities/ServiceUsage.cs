using ServeHub.Domain.Entities.Common;
using ServeHub.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace ServeHub.Domain.Entities
{
    public class ServiceUsage : BaseEntity
    {
        public Guid serviceId { get; private set; }
        public Service? service { get; private set; }
        public decimal priceAtPurchase { get; private set; }

        public Guid? orderId { get; private set; }
        public Order? order { get; private set; }

        public DateTimeOffset startedAt { get; private set; } = DateTimeOffset.UtcNow;
        public DateTimeOffset? endedAt { get; private set; }

        public ServiceUsageStatus serviceUsageStatus { get; private set; } = ServiceUsageStatus.Active;


        private ServiceUsage()
        { }
        }
}
