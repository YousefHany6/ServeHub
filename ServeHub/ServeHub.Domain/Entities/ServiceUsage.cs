using ServeHub.Domain.Entities.Common;
using ServeHub.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace ServeHub.Domain.Entities
{
    public class ServiceUsage : BaseEntity
    {
        public string serviceId { get; set; }
        public Service? service { get; set; }


        public string? orderId { get; set; }
        public Order? order { get; set; }

        public DateTimeOffset startedAt { get; set; } = DateTimeOffset.UtcNow;
        public DateTimeOffset? endedAt { get; set; }

        public ServiceUsageStatus serviceUsageStatus { get; set; } = ServiceUsageStatus.Active;
    }
}
