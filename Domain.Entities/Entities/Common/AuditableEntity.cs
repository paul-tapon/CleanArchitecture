using System;
using System.Text.Json.Serialization;

namespace Core.Domain.Model.Entities.Common
{
    public class AuditableEntity 
    {
        public int? CreatedByUserId { get; set; }

        public virtual User CreatedByUser { get; set; }

        public int? LastModifiedByUserId { get; set; }

        public virtual User LastModifiedByUser { get; set; }

        public DateTime Created { get; set; }
        public DateTime? LastModified { get; set; }
    }
}
