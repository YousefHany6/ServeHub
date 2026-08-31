using ServeHub.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace ServeHub.Domain.Entities
{
    public class Printer : BaseEntity
    {
        public string name { get; set; }
      
        public string? ipAddress { get; set; }
        public int? port { get; set; }

        public bool isActive { get; set; } = true;

        public string branchId { get; set; }
        public Branch? branch { get; set; }
    }
}
