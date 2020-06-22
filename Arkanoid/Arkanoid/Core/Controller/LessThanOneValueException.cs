using System;

namespace Arkanoid.Core.Controller
{
    public class LessThanOneValueException : Exception
    {
        public LessThanOneValueException(string message):base(message){ }
    }
}