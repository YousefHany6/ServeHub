using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ServeHub.Domain.Entities
{
    public class BranchEmployee
    {
    
        public string branchId { get; private set; }
      
        public string employeeId { get; private set; }

        public Branch? branch { get; private set; }
        public Employee? employee { get; private set; }

        private BranchEmployee() { }

        internal BranchEmployee(string branchId, string employeeId)
        {
            this.branchId = branchId;
            this.employeeId = employeeId;
        }
    }
}
