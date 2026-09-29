using ServeHub.Domain.Entities.Common;

namespace ServeHub.Domain.Entities
{
    public class DomainRole:BaseEntity
    {
        public string roleName { get; private set; }
        private DomainRole()
        { }

        private readonly List<EmployeeRole> _employeeRoles = new List<EmployeeRole>();
        public IReadOnlyCollection<EmployeeRole> EmployeeRoles => _employeeRoles.AsReadOnly();
        

        private readonly List<RolePermission> _rolePermissions = new List<RolePermission>();
        public IReadOnlyCollection<RolePermission> RolePermissions => _rolePermissions.AsReadOnly();
      
    }
}
