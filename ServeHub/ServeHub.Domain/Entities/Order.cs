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
        public Guid branchId { get; private set; }
        public Branch? branch { get; private set; }

        public Guid? customerId { get; private set; }
        public Customer? customer { get; private set; }

        public Guid? tableId { get; private set; }
        public Table? table { get; private set; }
        public Guid? receivedByEmployeeId { get; private set; }
        public Employee? receivedByEmployee { get; private set; }

        public Guid? deliveredByEmployeeId { get; private set; }
        public Employee? deliveredByEmployee { get; private set; }
       
        public Invoice? invoice { get; private set; }

        private readonly List<OrderItem> _orderItems = new List<OrderItem>();
        public IReadOnlyCollection<OrderItem> OrderItems => _orderItems.AsReadOnly();

        private readonly List<OrderStatusHistory> _orderStatusHistories = new List<OrderStatusHistory>();
        public IReadOnlyCollection<OrderStatusHistory> OrderStatusHistories => _orderStatusHistories.AsReadOnly();
        
        private readonly List<ServiceUsage> _serviceUsages = new List<ServiceUsage>();
        public IReadOnlyCollection<ServiceUsage> ServiceUsages => _serviceUsages.AsReadOnly();


        private Order() { }
    }
}
