using System;
using System.Collections.Generic;
using System.Text;

namespace ServeHub.Domain.Entities
{
    public class EmployeeRole
    {
        public Role Role { get; set; }
        public Employee employee { get; set; }

        public Guid roleId { get; set; }
        public Guid employeeId { get; set; }
    }
}
