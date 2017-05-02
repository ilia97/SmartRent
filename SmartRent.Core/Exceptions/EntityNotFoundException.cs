using System;

namespace SmartRent.Core.Exceptions
{
    [Serializable]
    public abstract class EntityNotFoundException : Exception
    {
        protected EntityNotFoundException()
        {
        }

        protected EntityNotFoundException(string message)
            : base(message)
        {
        }

        protected EntityNotFoundException(string message, Exception inner)
            : base(message, inner)
        {
        }
    }
}
