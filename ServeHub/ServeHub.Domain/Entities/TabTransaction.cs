using ServeHub.Domain.Entities.Common;
using ServeHub.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace ServeHub.Domain.Entities
{
    public class TabTransaction : BaseEntity
    {
        public Guid customerTabId { get; private set; }
        public CustomerTab? customerTab { get; private set; }

        public TabTransactionType tabTransactionType { get; private set; }
        public decimal amount { get; private set; }

        public Guid? orderId { get; private set; }             
        public Order? order { get; private set; }

        public string? note { get; private set; }
        public string? recordedByEmployeeId { get; private set; } 

        private TabTransaction()
        { }
    }
}
