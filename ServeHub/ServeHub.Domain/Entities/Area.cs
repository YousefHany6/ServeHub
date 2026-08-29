using ServeHub.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace ServeHub.Domain.Entities
{
    public class Area : BaseEntity
    {
        public string name { get; set; } 

        public string branchId { get; set; }
        public Branch? branch { get; set; }

        public ICollection<Table>? tables { get; set; } = new List<Table>();
    }
}
