using ServeHub.Domain.Entities.Common;
using ServeHub.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace ServeHub.Domain.Entities
{
    public class OrderStatusHistory : BaseEntity
    {
        public OrderStatus status { get; private set; }

        public Guid orderId { get; private set; }
        public Order? order { get; private set; }

        
        public Guid changedByEmployeeId { get; private set; }
        public Employee? changedByEmployee { get; private set; }

        private OrderStatusHistory()
        { }
    }
}
