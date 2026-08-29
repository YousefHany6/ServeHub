using ServeHub.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace ServeHub.Domain.Entities
{
    public class UserAddress : BaseEntity
    {
        public string address { get; set; }
      
        public string userId { get; set; }
       
    }
}
