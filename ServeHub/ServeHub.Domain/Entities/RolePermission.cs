using System;
using System.Collections.Generic;
using System.Text;

namespace ServeHub.Domain.Entities
{
    public class RolePermission
    {
        public Role role { get; set; }
        public Permission permission { get; set; }

        public Guid roleId { get; set; }

        public Guid permissionId { get; set; }
    }
}
