using ServeHub.Domain.Entities.Common;
using ServeHub.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace ServeHub.Domain.Entities
{
    public class Employee:BaseEntity
    {
        public EmpStatus empStatus { get; private set; } = EmpStatus.Active;
        
        public Guid userId { get; private set; }
        private Employee() { }

        private readonly List<SalaryConfig> _salaryConfig = new List<SalaryConfig>();
        public IReadOnlyCollection<SalaryConfig> salaryConfig => _salaryConfig.AsReadOnly();

        private readonly List<StaffTransaction> _staffTransactions = new List<StaffTransaction>();
        public IReadOnlyCollection<StaffTransaction> staffTransactions => _staffTransactions.AsReadOnly();

        private readonly List<SalaryPayment> _salaryPayments = new List<SalaryPayment>();

        public IReadOnlyCollection<SalaryPayment> salaryPayments => _salaryPayments.AsReadOnly();

        
        private readonly List<WorkLog> _workLogs = new List<WorkLog>();
        public IReadOnlyCollection<WorkLog> workLogs => _workLogs.AsReadOnly();

        
        private readonly List<BranchEmployee> _branchEmployees = new List<BranchEmployee>();
        public IReadOnlyCollection<BranchEmployee> branchEmployees => _branchEmployees.AsReadOnly();

        private readonly List<EmployeeRole> _employeeRoles = new List<EmployeeRole>();
        public IReadOnlyCollection<EmployeeRole> employeeRoles => _employeeRoles.AsReadOnly();
        

        private readonly List<OrderStatusHistory> _orderStatusHistories = new List<OrderStatusHistory>();
        public IReadOnlyCollection<OrderStatusHistory> orderStatusHistories => _orderStatusHistories.AsReadOnly();
        
        private readonly List<Product> _products = new List<Product>();
        public IReadOnlyCollection<Product> products => _products.AsReadOnly();
        
    }
}
