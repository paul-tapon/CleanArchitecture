using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Domain.Model.Entities.Common
{
    public class User : AuditableEntity
    {
        public int UserId { get; set; }
        public string Username { get; set; }

        public int OrganizationId { get; set; }
        public virtual Organization Organization { get; set; }
    }
}
