using ServeHub.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace ServeHub.Domain.Entities
{

    public class Branch : BaseEntity
    {
        public string branchName { get; private set; }
        public string? branchAddress { get; private set; }

        private readonly List<BranchEmployee> _branchEmployees = new();
        public IReadOnlyCollection<BranchEmployee> BranchEmployees => _branchEmployees.AsReadOnly();

        private readonly List<BranchCategory> _branchCategories = new();
        public IReadOnlyCollection<BranchCategory> BranchCategories => _branchCategories.AsReadOnly();

        private readonly List<BranchProductVariant> _branchProductVariants = new();
        public IReadOnlyCollection<BranchProductVariant> BranchProductVariants => _branchProductVariants.AsReadOnly();

        private readonly List<Order> _orders = new();
        public IReadOnlyCollection<Order> Orders => _orders.AsReadOnly();

        private readonly List<Area> _areas = new();
        public IReadOnlyCollection<Area> Areas => _areas.AsReadOnly();

        private readonly List<Printer> _printers = new();
        public IReadOnlyCollection<Printer> Printers => _printers.AsReadOnly();

        private Branch() { }

        // Add New Branch
        public Branch(string branchName, string branchAddress)
        {
            if (string.IsNullOrWhiteSpace(branchName))
            {
                throw new ArgumentException($"{nameof(branchName)} Can Not Be Empty");
            }

            this.branchName = branchName;
            this.branchAddress = branchAddress;
        }
        // Update Branch

        public void UpdateBranch(string branchName, string branchAddress)
        {
            if (string.IsNullOrWhiteSpace(branchName))
            {
                throw new ArgumentException($"{nameof(branchName)} Can Not Be Empty");
            }
            this.branchName = branchName;
            this.branchAddress = branchAddress;
        }
        // Add Branch Employee

       

    }
}
