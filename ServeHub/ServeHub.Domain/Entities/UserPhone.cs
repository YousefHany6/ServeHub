using ServeHub.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace ServeHub.Domain.Entities
{
    public class UserPhone : BaseEntity
    {
        public string phone { get; private set; }
        public bool isPrimary { get; private set; } 

        public Guid userId { get; private set; }

        private UserPhone()
        { }

    }
}
