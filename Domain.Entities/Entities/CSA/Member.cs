using Core.Domain.Model.Entities.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Domain.Model.Entities.CSA
{
    public class Member : AuditableEntity
    {
        public Member()
        {
            Accounts = new HashSet<Account>();
        }
        public int MemberId { get; set; }

        public string MemberNo { get; set; }

        public ICollection<Account> Accounts { get; set; }

    }

    public class Account : AuditableEntity
    {
        public int AccountId { get; set; }

        public string AccountNo { get; set; }

        public int MemberId { get; set; }
        public virtual Member Member { get; set; }
    }
}
