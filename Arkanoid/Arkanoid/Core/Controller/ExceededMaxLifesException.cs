using System;

namespace Arkanoid.Core.Controller
{
    public class ExceededMaxLifesException : Exception
    {
        public ExceededMaxLifesException(string message) : base(message){}
    }
}