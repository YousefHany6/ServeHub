using ServeHub.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace ServeHub.Domain.Entities
{
    public class Permission: BaseEntity
    {
        public string permissionName { get; private set; }

        private Permission()
        { }

    }
}
