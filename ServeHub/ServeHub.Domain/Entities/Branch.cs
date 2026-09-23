using ServeHub.Domain.Constants;
using ServeHub.Domain.Entities.Common;
using ServeHub.Domain.Exceptions;


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
        public Branch(string branchName, string? branchAddress)
        {
            SetBranchName(branchName);
            this.branchAddress = branchAddress;
        }

        // Update Branch
        public void UpdateBranch(string branchName, string? branchAddress)
        {
            SetBranchName(branchName);
            this.branchAddress = branchAddress;
        }

        // set name
        private void SetBranchName(string branchName)
        {
            if (string.IsNullOrWhiteSpace(branchName))
            {
                throw new DomainException(DomainErrors.Branch.NameCannotBeEmpty);
            }
            this.branchName = branchName;
        }

        // Add Branch Employee
        public void AddBranchEmployee(Guid employeeId)
        {
            if (_branchEmployees.Any(be => be.employeeId == employeeId))
            {
                throw new DomainException(DomainErrors.Branch.EmployeeAlreadyAssigned);
            }
            var branchEmployee = new BranchEmployee(this.Id, employeeId);
            _branchEmployees.Add(branchEmployee);
        }

        // Remove Employee from Branch
        public void RemoveBranchEmployee(Guid employeeId)
        {
            var branchEmployee = _branchEmployees.FirstOrDefault(be => be.employeeId == employeeId);
            if (branchEmployee == null)
            {
                throw new DomainException(DomainErrors.Branch.EmployeeNotAssigned);
            }
            _branchEmployees.Remove(branchEmployee);
        }

        // Add Category to Branch (category can not be added twice to the same branch)
        public void AddBranchCategory(Guid categoryId)
        {
            if (_branchCategories.Any(bc => bc.categoryId == categoryId))
            {
                throw new DomainException(DomainErrors.Branch.CategoryAlreadyAssigned);
            }
            var branchCategory = new BranchCategory(this.Id, categoryId);
            _branchCategories.Add(branchCategory);
        }

        // Remove Category from Branch
        public void RemoveBranchCategory(Guid categoryId)
        {
            var branchCategory = _branchCategories.FirstOrDefault(bc => bc.categoryId == categoryId);
            if (branchCategory == null)
            {
                throw new DomainException(DomainErrors.Branch.CategoryNotAssigned);
            }
            _branchCategories.Remove(branchCategory);
        }

        // Add Product Variant to Branch (product variant can not be added twice to the same branch)
        public void AddBranchProductVariant(Guid productVariantId, bool isAvailable, decimal price)
        {
            if (_branchProductVariants.Any(bp => bp.productVariantId == productVariantId))
            {
                throw new DomainException(DomainErrors.Branch.ProductVariantAlreadyAssigned);
            }
            var branchProductVariant = new BranchProductVariant(this.Id, productVariantId, isAvailable, price);
            _branchProductVariants.Add(branchProductVariant);

        }

        // Remove Product Variant from Branch
        public void RemoveBranchProductVariant(Guid productVariantId)
        {
            var branchProductVariant = _branchProductVariants.FirstOrDefault(bp => bp.productVariantId == productVariantId);
            if (branchProductVariant == null)
            {
                throw new DomainException(DomainErrors.Branch.ProductVariantNotAssigned);
            }
            _branchProductVariants.Remove(branchProductVariant);
        }
    }
}
