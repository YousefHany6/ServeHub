using ServeHub.Domain.Entities.Common;

namespace ServeHub.Domain.Entities
{
    public class UserAddress : BaseEntity
    {
        public string address { get; private set; }
      
        public Guid userId { get; private set; }

        private UserAddress()
        { }

    }
}
