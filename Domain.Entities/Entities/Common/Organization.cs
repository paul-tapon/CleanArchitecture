using System.Collections.Generic;

namespace Core.Domain.Model.Entities.Common
{
    public class Organization : AuditableEntity
    {
        public Organization()
        {
            Users = new HashSet<User>();
        }
        public int OrganizationId { get; set; }

        public string Name { get; set; }

        public ICollection<User> Users { get; set; }
    }
}
