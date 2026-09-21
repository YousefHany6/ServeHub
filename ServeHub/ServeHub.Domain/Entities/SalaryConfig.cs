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
        public decimal baseAmount { get; private set; }
        public SalaryType salaryType { get; private set; }

        
        public Employee? employee { get; private set; }
        public Guid employeeId { get; private set; }

        private SalaryConfig()
        { }
    }
}
