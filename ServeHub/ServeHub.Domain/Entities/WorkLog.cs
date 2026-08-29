using ServeHub.Domain.Entities.Common;
using ServeHub.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace ServeHub.Domain.Entities
{
    public class WorkLog:BaseEntity
    {
        public WorkLogStatus workLogStatus { get; set; }

        public string employeeId { get; set; }
        public Employee? employee { get; set; }


        public string recordedByEmployeeId { get; set; }
        public Employee? recordedByEmployee { get; set; }

    }
}
