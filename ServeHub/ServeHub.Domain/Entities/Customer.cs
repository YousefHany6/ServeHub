using ServeHub.Domain.Entities.Common;
using ServeHub.Domain.Enums;

namespace ServeHub.Domain.Entities
{
    public class Customer :BaseEntity
    {
        public Guid userId { get; private set; }
        public AccStatus accStatus { get; private set; }=AccStatus.Active;
        public Cart? cart { get; private set; }
        private Customer() { }

        private readonly List<Order> _orders = new();
        public IReadOnlyCollection<Order> Orders => _orders.AsReadOnly();
        public void UpdateCustomerStatus(AccStatus accStatus)
        {
            this.accStatus = accStatus;
        }
    }
}
