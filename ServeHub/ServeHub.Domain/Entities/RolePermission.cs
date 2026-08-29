using System;
using System.Collections.Generic;
using System.Text;

namespace ServeHub.Domain.Entities
{
    public class RolePermission
    {
        public Role role { get; set; }
        public Permission permission { get; set; }

        public string roleId { get; set; }

        public string permissionId { get; set; }
    }
}
