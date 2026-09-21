using ServeHub.Domain.Entities.Common;
using ServeHub.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace ServeHub.Domain.Entities
{
    public class CashShift : BaseEntity
    {
        public Guid branchId { get; set; }
        public Branch? branch { get; set; }

        public Guid openedByEmployeeId { get; set; }    
        public Employee? openedByEmployee { get; set; }

        public Guid? closedByEmployeeId { get; set; }

        public DateTimeOffset openedAt { get; set; } = DateTimeOffset.UtcNow;
        public DateTimeOffset? closedAt { get; set; }

        public decimal openingFloat { get; set; }          

        public CashShiftStatus cashShiftStatus { get; set; } = CashShiftStatus.Open;

      
        public decimal? countedAmount { get; set; }        
        public decimal? varianceAmount { get; set; }     
        public string? closingNote { get; set; }           

        public ICollection<CashMovement>? cashMovements { get; set; } = new List<CashMovement>();
    }
}
