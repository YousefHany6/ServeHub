using System;
using System.Collections.Generic;
using System.Text;

namespace ServeHub.Domain.Entities
{
    public class BranchCategory
    {
        public string branchId { get; private set; }
        public string categoryId { get; private set; }

        public Branch? branch { get; private set; }
        public Category? category { get; private set; }
        private BranchCategory() { }
        internal BranchCategory(string branchId, string categoryId)
        {
            this.branchId = branchId;
            this.categoryId = categoryId;
        }
    }
}
