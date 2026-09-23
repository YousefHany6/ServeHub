using ServeHub.Domain.Entities.Common;

namespace ServeHub.Domain.Entities
{
    public class SalaryPayment : BaseEntity
    {
        public decimal baseAmount { get; private set; }
        public decimal bonusTotal { get; private set; }
        public decimal deductionTotal { get; private set; }
        public decimal advanceTotal { get; private set; }
        public decimal totalAmount { get; private set; }
        public DateOnly Month { get; private set; }

        
        public Guid employeeId { get; private set; }
        public Employee? employee { get; private set; }

        
        public Guid recordedByEmployeeId { get; private set; }
        public Employee? recordedByEmployee { get; private set; }

        private SalaryPayment()
        { }
    }
}
