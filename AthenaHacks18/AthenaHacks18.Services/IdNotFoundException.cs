using System;

namespace AthenaHacks18.Services
{
    public class IdNotFoundException : Exception
    {
        public IdNotFoundException(string message) : base(message)
        {

        }
    }
}
