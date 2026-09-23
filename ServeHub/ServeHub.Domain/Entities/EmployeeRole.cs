namespace ServeHub.Domain.Entities
{
    public class EmployeeRole
    {
        public Role Role { get; private set; }
        public Employee employee { get; private set; }

        public Guid roleId { get; private set; }
        public Guid employeeId { get; private set; }

        private EmployeeRole() { }
    }
}
