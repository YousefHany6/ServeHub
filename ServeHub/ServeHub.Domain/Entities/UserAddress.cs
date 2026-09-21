using ServeHub.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace ServeHub.Domain.Entities
{
    public class UserAddress : BaseEntity
    {
        public string address { get; private set; }
      
        public Guid userId { get; private set; }

        private UserAddress()
        { }

    }
}
