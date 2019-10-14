using System;

namespace Core.Application.Common.Exceptions
{
    public class EntityNotFoundException : Exception
    {
        public EntityNotFoundException(string entityName, object key)
           : base($"Entity \"{entityName}\" ({key}) was not found.")
        {
        }
    }
}
