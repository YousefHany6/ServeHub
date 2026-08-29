using System;
using System.Collections.Generic;
using System.Text;

namespace ServeHub.Domain.Entities
{
    public class BranchCategory
    {
        public string branchId { get; set; }
        public string categoryId { get; set; }

        public Branch? branch { get; set; }
        public Category? category { get; set; }
    }
}
