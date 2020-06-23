using System;

namespace Arkanoid.Core.Controller
{
    public class ExceededMaxCharactersException : Exception
    {
        public ExceededMaxCharactersException(string message):base(message){ }
    }
}