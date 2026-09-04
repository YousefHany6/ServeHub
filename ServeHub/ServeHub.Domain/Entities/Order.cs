using ServeHub.Domain.Entities.Common;
using ServeHub.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace ServeHub.Domain.Entities
{
    

    public class Order : BaseEntity
    {
        public SaleChannel saleChannel { get;  private  set; }
        public string? shippingAddress { get; private set; }
        public OrderType orderType { get; private set; }
        public string? note { get; private set; }
        public string branchId { get; private set; }
        public Branch? branch { get; private set; }

        public string? customerId { get; private set; }
        public Customer? customer { get; private set; }

        public string? tableId { get; private set; }
        public Table? table { get; private set; }
        public string? receivedByEmployeeId { get; private set; }
        public Employee? receivedByEmployee { get; private set; }

        public string? deliveredByEmployeeId { get; private set; }
        public Employee? deliveredByEmployee { get; private set; }
       
        public Invoice? invoice { get; private set; }

        private readonly List<OrderItem> _orderItems = new List<OrderItem>();
        public IReadOnlyCollection<OrderItem> OrderItems => _orderItems.AsReadOnly();

        
        public ICollection<OrderStatusHistory>? orderStatusHistories { get; set; } = new List<OrderStatusHistory>();
        public ICollection<ServiceUsage>? serviceUsages { get; private set; } = new List<ServiceUsage>();

       
       

    }
}
