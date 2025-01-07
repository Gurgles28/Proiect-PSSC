using System;

namespace Example.Domain.Exceptions
{
    public class InvalidShipmentException : Exception
    {
        public InvalidShipmentException(string message) : base(message)
        {
        }
    }
}