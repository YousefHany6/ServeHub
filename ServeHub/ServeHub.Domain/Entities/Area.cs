using ServeHub.Domain.Constants;
using ServeHub.Domain.Entities.Common;
using ServeHub.Domain.Exceptions;
using System;
using System.Collections.Generic;
using System.Text;

namespace ServeHub.Domain.Entities
{
    public class Area : BaseEntity
    {
        public string name { get; private set; } 

        public string branchId { get; private set; }
        public Branch? branch { get; private set; }
        private Area() { }

        // Add New Area

        public Area(string name, string branchId)
        {
            SetName(name);
            SetBranchId(branchId);
        }

        // Update Area Name Or BranchId
        public void Update(string name, string branchId)
        {
            SetName(name);
            if (!string.IsNullOrWhiteSpace(branchId))
            {
                SetBranchId(branchId);
            }
        }

        //set name
        private void SetName(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new DomainException(DomainErrors.Area.NameCannotBeEmpty);
            }
            this.name = name;
        }

        // set branchId
        private void SetBranchId(string branchId)
        {
            if (string.IsNullOrWhiteSpace(branchId))
            {
                throw new DomainException(DomainErrors.Area.BranchIdCannotBeEmpty);
            }
            this.branchId = branchId;
        }

        public ICollection<Table>? tables { get; set; } = new List<Table>();
    }
}
