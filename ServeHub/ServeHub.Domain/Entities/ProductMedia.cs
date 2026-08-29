using ServeHub.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace ServeHub.Domain.Entities
{
    public class ProductMedia:BaseEntity
    {
        public string mediaUrl { get; set; }

        public string productId { get; set; }
        public Product? product { get; set; }
    }
}
