using ServeHub.Domain.Entities.Common;
using ServeHub.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace ServeHub.Domain.Entities
{
    public class OrderStatusHistory : BaseEntity
    {
        public OrderStatus status { get; set; }

        public Guid orderId { get; set; }
        public Order? order { get; set; }

        
        public Guid changedByEmployeeId { get; set; }
        public Employee? changedByEmployee { get; set; }
    }
}
