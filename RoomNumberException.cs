using System;

namespace ExceptionTask
{
    public class roomNumberException : Exception
    {        
        public roomNumberException(string message) : base(message) {}
    }
}
