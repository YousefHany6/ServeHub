using ServeHub.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace ServeHub.Domain.Entities
{
    public class Table : BaseEntity
    {
        public string name { get; private set; } 
        
        public Guid areaId { get; private set; }
        public Area? area { get; private set; }

        private Table()
        { }

        private readonly List<Order> _orders = new List<Order>();
        public IReadOnlyCollection<Order> Orders => _orders.AsReadOnly();
        
    }
}
