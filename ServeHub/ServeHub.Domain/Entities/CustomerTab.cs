using ServeHub.Domain.Entities.Common;
using ServeHub.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace ServeHub.Domain.Entities
{
    public class CustomerTab : BaseEntity
    {
       
        public string tabName { get; private set; }   
        public string? phone { get; private set; }    

        public TabStatus tabStatus { get; private set; } = TabStatus.Active;
        public decimal? creditLimit { get; private set; } 
        private CustomerTab() { }
        private readonly List<TabTransaction> _tabTransactions = new();
        public IReadOnlyCollection<TabTransaction> tabTransactions => _tabTransactions.AsReadOnly();
        //public ICollection<TabTransaction>? tabTransactions { get; private set; } = new List<TabTransaction>();
    }
}
