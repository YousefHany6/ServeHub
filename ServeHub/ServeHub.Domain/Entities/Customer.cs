using ServeHub.Domain.Entities.Common;
using ServeHub.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace ServeHub.Domain.Entities
{
    public class Customer :BaseEntity
    {
        public Guid userId { get; set; }
        public AccStatus accStatus { get; set; }
        public Cart? cart { get; set; }
        public ICollection<Order>? orders { get; set; } = new List<Order>();
    }
}
