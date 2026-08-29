using System;
using System.Collections.Generic;
using System.Text;

namespace ServeHub.Domain.Enums
{
    public enum CashMovementType
    {
        SalePayment,      
        TabPayment,       
        Refund,           
        Payout,           
        OwnerWithdrawal,  
        SafeDrop,         
        AdvanceToStaff,   
        ManualIn,         
        ManualOut         
    }
}
