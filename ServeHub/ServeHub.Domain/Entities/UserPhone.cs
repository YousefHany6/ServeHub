using ServeHub.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace ServeHub.Domain.Entities
{
    public class UserPhone : BaseEntity
    {
        public string phone { get; set; }
        public bool isPrimary { get; set; } 

        public Guid userId { get; set; }
       
    }
}
