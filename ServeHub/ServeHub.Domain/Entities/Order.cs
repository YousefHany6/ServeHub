using ServeHub.Domain.Entities.Common;
using ServeHub.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace ServeHub.Domain.Entities
{
    public class Order : BaseEntity
    {
        public SaleChannel saleChannel { get; set; }
        public string? shippingAddress { get; set; }

        public string branchId { get; set; }
        public Branch? branch { get; set; }

        public string? customerId { get; set; }
        public Customer? customer { get; set; }

        public string? tableId { get; set; }
        public Table? table { get; set; }
        public string? receivedByEmployeeId { get; set; }
        public Employee? receivedByEmployee { get; set; }

        public string? deliveredByEmployeeId { get; set; }
        public Employee? deliveredByEmployee { get; set; }
        public OrderType orderType { get; set; }

        public string? note { get; set; }
        public ICollection<OrderItem>? orderItems { get; set; } = new List<OrderItem>();
        public ICollection<OrderStatusHistory>? orderStatusHistories { get; set; } = new List<OrderStatusHistory>();
        public Invoice? invoice { get; set; }
        public ICollection<ServiceUsage>? serviceUsages { get; set; } = new List<ServiceUsage>();

    }
}
