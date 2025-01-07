using System;

namespace Example.Domain.Exceptions
{
    public class InvalidInvoiceException : Exception
    {
        public InvalidInvoiceException(string message) : base(message)
        {
        }
    }
}