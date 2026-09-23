using System.ComponentModel.DataAnnotations;

namespace ServeHub.Domain.Entities.Common
{
    public abstract class BaseEntity
    {
        [Key]
        public Guid Id { get; private set; } 

        public DateTimeOffset CreatedAt { get;  private set; } = DateTimeOffset.UtcNow;


    }
}
