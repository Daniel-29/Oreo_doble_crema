using System;

namespace Arkanoid.Core.Controller
{
    public class NoRemainingLifesException : Exception
    {
        public NoRemainingLifesException(string message):base(message){ }
    }
}