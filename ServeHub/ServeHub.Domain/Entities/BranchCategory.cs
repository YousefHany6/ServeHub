using System;
using System.Collections.Generic;
using System.Text;

namespace ServeHub.Domain.Entities
{
    public class BranchCategory
    {
        public Guid branchId { get; private set; }
        public Guid categoryId { get; private set; }

        public Branch? branch { get; private set; }
        public Category? category { get; private set; }
        private BranchCategory() { }
        internal BranchCategory(Guid branchId, Guid categoryId)
        {
            this.branchId = branchId;
            this.categoryId = categoryId;
        }
    }
}
