using ServeHub.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace ServeHub.Domain.Entities
{
    public class ProductMedia:BaseEntity
    {
        public string mediaUrl { get; private set; }

        public Guid productId { get; private set; }
        public Product? product { get; private set; }

        private ProductMedia()
        { }
    }
}
