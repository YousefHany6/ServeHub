using Microsoft.AspNetCore.Identity;

namespace ServeHub.Infrastructure.Identity
{
    public class ApplicationUser : IdentityUser<Guid>
    {
        public ApplicationUser()
        {
            Id=Guid.CreateVersion7();
        }
    }
}
