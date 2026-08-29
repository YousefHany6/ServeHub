using System;
using System.Collections.Generic;
using System.Text;

namespace ServeHub.Domain.Entities
{
    public class EmployeeRole
    {
        public Role Role { get; set; }
        public Employee employee { get; set; }

        public string roleId { get; set; }
        public string employeeId { get; set; }
    }
}
