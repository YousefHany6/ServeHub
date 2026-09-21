using System;
using System.Collections.Generic;
using System.Text;

namespace ServeHub.Domain.Entities
{
    public class RolePermission
    {
        public Role role { get; private set; }
        public Permission permission { get; private set; }

        public Guid roleId { get; private set; }

        public Guid permissionId { get; private set; }

        private RolePermission()
        { }
    }
}
