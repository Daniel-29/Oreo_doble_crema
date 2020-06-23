using System;

namespace Arkanoid.Core.Controller
{
    public class EmptyNicknameException : Exception
    {
        public EmptyNicknameException(string message):base(message){ }
    }
}