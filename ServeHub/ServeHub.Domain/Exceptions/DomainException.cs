using System;
using System.Collections.Generic;
using System.Text;

namespace ServeHub.Domain.Exceptions
{
    public class DomainException:Exception
    {
        public string ErrorCode { get; }
        public string[]? Args { get; }

        public DomainException(string errorCode)
            : base(errorCode)
        {
            ErrorCode = errorCode;
        }

        public DomainException(string errorCode, params string[] args)
            : base(errorCode)
        {
            ErrorCode = errorCode;
            Args = args;
        }


    }
}
