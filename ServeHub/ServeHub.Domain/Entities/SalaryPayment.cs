using ServeHub.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace ServeHub.Domain.Entities
{
    public class SalaryPayment : BaseEntity
    {
        public decimal baseAmount { get; set; }
        public decimal bonusTotal { get; set; }
        public decimal deductionTotal { get; set; }
        public decimal advanceTotal { get; set; }
        public decimal totalAmount { get; set; }
        public DateOnly Month { get; set; }

        
        public string employeeId { get; set; }
        public Employee? employee { get; set; }

        
        public string recordedByEmployeeId { get; set; }
        public Employee? recordedByEmployee { get; set; }
    }
}
