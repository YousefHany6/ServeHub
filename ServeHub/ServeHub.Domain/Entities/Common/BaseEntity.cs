using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ServeHub.Domain.Entities.Common
{
    public abstract class BaseEntity
    {
        [Key]
        public Guid Id { get; private set; } = Guid.CreateVersion7();

        public DateTimeOffset CreatedAt { get;  private set; } = DateTimeOffset.UtcNow;


    }
}
