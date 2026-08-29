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
        public TransactionType transactionType { get; set; }
        public decimal amount { get; set; }
        public TransactionStatus transactionStatus { get; set; }
         public string? Note { get; set; }

        
        public string employeeId { get; set; }
        public Employee? employee { get; set; }

        
        public string recordedByEmployeeId { get; set; }
        public Employee? recordedByEmployee { get; set; }
    }
}
