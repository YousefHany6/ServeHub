using ServeHub.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace ServeHub.Domain.Entities
{
    public class Role:BaseEntity
    {
        public string roleName { get; set; }

        public ICollection<EmployeeRole>? employeeRoles { get; set; } = new List<EmployeeRole>();
        public ICollection<RolePermission>? rolePermissions { get; set; } = new List<RolePermission>();
    }
}
