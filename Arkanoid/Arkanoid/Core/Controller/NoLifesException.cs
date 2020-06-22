using System;

namespace Arkanoid.Core.Controller
{
    public class NoLifesException : Exception
    {
        public NoLifesException(string message):base(message){ }
    }
}