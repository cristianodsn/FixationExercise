using System;

namespace Exceptions01.Entities.exceptions
{
    class DomainExceptions : ApplicationException
    {
        public DomainExceptions(string message) : base(message) { }
    }
}
