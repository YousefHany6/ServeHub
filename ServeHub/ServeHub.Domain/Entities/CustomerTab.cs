using ServeHub.Domain.Entities.Common;
using ServeHub.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace ServeHub.Domain.Entities
{
    public class CustomerTab : BaseEntity
    {
       
        public string tabName { get; set; }   
        public string? phone { get; set; }    

        public TabStatus tabStatus { get; set; } = TabStatus.Active;
        public decimal? creditLimit { get; set; } 

        public ICollection<TabTransaction>? tabTransactions { get; set; } = new List<TabTransaction>();
    }
}
