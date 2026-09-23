using ServeHub.Domain.Entities.Common;

namespace ServeHub.Domain.Entities
{
    public class Printer : BaseEntity
    {
        public string name { get; private set; }
      
        public string? ipAddress { get; private set; }
        public int? port { get; private set; }

        public bool isActive { get; private set; } = true;
        public string? sharedName { get; private set; }
        public Guid branchId { get; private set; }
        public Branch? branch { get; private set; }

        private Printer()
        { }
    }
}
