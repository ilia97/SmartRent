using System;

namespace SmartRent.Core.Exceptions
{
    [Serializable]
    public class AdminNotFoundException : EntityNotFoundException
    {
        public AdminNotFoundException()
        {
        }

        public AdminNotFoundException(string message)
            : base(message)
        {
        }

        public AdminNotFoundException(string message, Exception inner)
            : base(message, inner)
        {
        }
    }
}
