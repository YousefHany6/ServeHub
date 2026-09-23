namespace ServeHub.Domain.Entities
{
    public class BranchEmployee
    {
    
        public Guid branchId { get; private set; }
      
        public Guid employeeId { get; private set; }

        public Branch? branch { get; private set; }
        public Employee? employee { get; private set; }

        private BranchEmployee() { }

        internal BranchEmployee(Guid branchId, Guid employeeId)
        {
            this.branchId = branchId;
            this.employeeId = employeeId;
        }
    }
}
