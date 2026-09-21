using ServeHub.Domain.Entities.Common;
using ServeHub.Domain.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ServeHub.Domain.Entities
{
    public class StaffTransaction:BaseEntity
    {
        public TransactionType transactionType { get; private set; }
        public decimal amount { get; private set; }
        public TransactionStatus transactionStatus { get; private set; }
         public string? Note { get; private set; }

        
        public Guid employeeId { get; private set; }
        public Employee? employee { get; private set; }

        
        public Guid recordedByEmployeeId { get; private set; }
        public Employee? recordedByEmployee { get; private set; }
    }
}
