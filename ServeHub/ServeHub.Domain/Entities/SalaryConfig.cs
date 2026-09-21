using ServeHub.Domain.Entities.Common;
using ServeHub.Domain.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ServeHub.Domain.Entities
{
    public class SalaryConfig:BaseEntity
    {
        public decimal baseAmount { get; set; }
        public SalaryType salaryType { get; set; }

        
        public Employee? employee { get; set; }
        public Guid employeeId { get; set; }
    }
}
