using ServeHub.Domain.Entities.Common;
using ServeHub.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace ServeHub.Domain.Entities
{
    public class CashMovement : BaseEntity
    {
        public Guid cashShiftId { get; set; }
        public CashShift? cashShift { get; set; }

        public CashMovementDirection direction { get; set; }
        public CashMovementType cashMovementType { get; set; }
        public decimal amount { get; set; }                    

        public string reason { get; set; }                      

        public Guid? invoiceId { get; set; }               
        public Invoice? invoice { get; set; }
        public Guid recordedByEmployeeId { get; set; }       
        public Employee? recordedByEmployee { get; set; }
    }
}
