using ServeHub.Domain.Entities.Common;
using ServeHub.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace ServeHub.Domain.Entities
{
    public class TabTransaction : BaseEntity
    {
        public Guid customerTabId { get; set; }
        public CustomerTab? customerTab { get; set; }

        public TabTransactionType tabTransactionType { get; set; }
        public decimal amount { get; set; }

        public Guid? orderId { get; set; }             
        public Order? order { get; set; }

        public string? note { get; set; }
        public string? recordedByEmployeeId { get; set; } 
    }
}
