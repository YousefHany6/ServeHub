using ServeHub.Domain.Entities.Common;
using ServeHub.Domain.Enums;

namespace ServeHub.Domain.Entities
{
    public class CashMovement : BaseEntity
    {
        public Guid cashShiftId { get; private set; }
        public CashShift? cashShift { get; private set; }

        public CashMovementDirection direction { get; private set; }
        public CashMovementType cashMovementType { get; private set; }
        public decimal amount { get; private set; }                    

        public string reason { get; private set; }                      

        public Guid? invoiceId { get; private set; }               
        public Invoice? invoice { get; private set; }
        public Guid recordedByEmployeeId { get; private set; }       
        public Employee? recordedByEmployee { get; private set; }

        private CashMovement()
        { }
        }
}
