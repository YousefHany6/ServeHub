using ServeHub.Domain.Entities.Common;

namespace ServeHub.Domain.Entities
{
    public class Permission: BaseEntity
    {
        public string permissionName { get; private set; }

        private Permission()
        { }

    }
}
