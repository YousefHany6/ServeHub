using System;
using System.Collections.Generic;
using System.Text;

namespace ServeHub.Domain.Enums
{
    public enum PaymentStatus
    {
        Pending,
        Paid,
        PartiallyPaid,
        Failed,
        Refunded
    }
}
