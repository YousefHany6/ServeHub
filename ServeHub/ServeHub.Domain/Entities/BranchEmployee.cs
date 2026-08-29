using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ServeHub.Domain.Entities
{
    public class BranchEmployee
    {
    
        public string branchId { get; set; }
      
        public string employeeId { get; set; }

        public Branch? branch { get; set; }
        public Employee? employee { get; set; }
    }
}
