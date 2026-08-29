using System;
using System.Collections.Generic;
using System.Text;

namespace ServeHub.Domain.Enums
{
    public enum OrderStatus
    {
        Pending,         
        Confirmed,       
        Preparing,       
        Ready,           
        OutForDelivery,  
        Delivered,       
        Cancelled,       
        Returned ,
        Completed
    }
}
