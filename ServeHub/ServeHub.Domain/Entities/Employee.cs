using ServeHub.Domain.Entities.Common;
using ServeHub.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace ServeHub.Domain.Entities
{
    public class Employee:BaseEntity
    {
        public EmpStatus empStatus { get; set; } = EmpStatus.Active;
        
        public Guid userId { get; set; }

        public ICollection<SalaryConfig>? salaryConfig { get; set; } = new List<SalaryConfig>();
        public ICollection<StaffTransaction>? staffTransactions { get; set; } = new List<StaffTransaction>();
        public ICollection<SalaryPayment>? salaryPayments { get; set; } = new List<SalaryPayment>();
        public ICollection<WorkLog>? workLogs { get; set; } = new List<WorkLog>();
        public ICollection<BranchEmployee>? branchEmployees { get; set; } = new List<BranchEmployee>();
        public ICollection<EmployeeRole>? employeeRoles { get; set; } = new List<EmployeeRole>();
        public ICollection<OrderStatusHistory>? orderStatusHistory { get; set; } = new List<OrderStatusHistory>();
        public ICollection<Product>? products { get; set; } = new List<Product>();
    }
}
