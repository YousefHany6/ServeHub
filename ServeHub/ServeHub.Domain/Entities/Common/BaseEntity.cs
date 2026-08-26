using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ServeHub.Domain.Entities.Common
{
    public abstract class BaseEntity
    {
        [Key]
        public string Id { get; set; } = Guid.NewGuid().ToString();

        public DateTimeOffset CreatedAt { get;  private set; } = DateTimeOffset.UtcNow;


    }
}
