using ServeHub.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace ServeHub.Domain.Entities
{
    public class Table : BaseEntity
    {
        public string name { get; set; } 
        
        public string areaId { get; set; }
        public Area? area { get; set; }

        
        public ICollection<Order>? orders { get; set; } = new List<Order>();
    }
}
