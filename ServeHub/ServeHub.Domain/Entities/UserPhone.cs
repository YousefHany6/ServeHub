using ServeHub.Domain.Entities.Common;

namespace ServeHub.Domain.Entities
{
    public class UserPhone : BaseEntity
    {
        public string phone { get; private set; }
        public bool isPrimary { get; private set; } 

        public Guid userId { get; private set; }

        private UserPhone()
        { }

    }
}
