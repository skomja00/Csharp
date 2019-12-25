using System;

namespace Packt.Shared
{
    public class PersonException : Exception
    {
        public PersonException() : base() { }
        public PersonException(string msg) : base(msg) { }
        public PersonException(string msg, Exception innerException) : base(msg, innerException) {}

    }
}