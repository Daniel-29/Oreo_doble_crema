using System;

namespace Arkanoid.Core.Controller
{
    public class WrongKeyException : Exception
    {
        public WrongKeyException(string message):base(message){ }
    }
}