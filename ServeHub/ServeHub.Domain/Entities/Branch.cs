using ServeHub.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace ServeHub.Domain.Entities
{

    public class Branch:BaseEntity
    {
        public string branchName { get; set; }
        public string branchAddress { get; set; }

        public ICollection<BranchEmployee>? branchEmployees { get; set; } = new List<BranchEmployee>();
        public ICollection<BranchCategory>? branchCategories { get; set; } = new List<BranchCategory>();
        public ICollection<BranchProductVariant>? branchProductVariants { get; set; } = new List<BranchProductVariant>();
        public ICollection<Order>? orders { get; set; } = new List<Order>();
        public ICollection<Area>? areas { get; set; } = new List<Area>();
    }
}
