using ServeHub.Domain.Entities.Common;
using ServeHub.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace ServeHub.Domain.Entities
{
    public class CashShift : BaseEntity
    {
        public Guid branchId { get; private set; }
        public Branch? branch { get; private set; }

        public Guid openedByEmployeeId { get; private set; }    
        public Employee? openedByEmployee { get; private set; }

        public Guid? closedByEmployeeId { get; private set; }

        public DateTimeOffset openedAt { get; private set; } = DateTimeOffset.UtcNow;
        public DateTimeOffset? closedAt { get; private set; }

        public decimal openingFloat { get; private set; }          

        public CashShiftStatus cashShiftStatus { get; private set; } = CashShiftStatus.Open;

      
        public decimal? countedAmount { get; private set; }        
        public decimal? varianceAmount { get; private set; }     
        public string? closingNote { get; private set; }
        private readonly List<CashMovement> _cashMovements = new List<CashMovement>();

        public IReadOnlyCollection<CashMovement> cashMovements => _cashMovements.AsReadOnly();

        private CashShift() { }
    }
}
