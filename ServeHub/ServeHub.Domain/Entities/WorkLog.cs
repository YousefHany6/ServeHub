using ServeHub.Domain.Entities.Common;
using ServeHub.Domain.Enums;

namespace ServeHub.Domain.Entities
{
    public class WorkLog:BaseEntity
    {
        public WorkLogStatus workLogStatus { get; private set; }

        public Guid employeeId { get; private set; }
        public Employee? employee { get; private set; }


        public Guid recordedByEmployeeId { get; private set; }
        public Employee? recordedByEmployee { get; private set; }

    }
}
