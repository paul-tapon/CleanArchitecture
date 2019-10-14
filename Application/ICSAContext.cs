using Core.Domain.Model.Entities.Common;
using Core.Domain.Model.Entities.CSA;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Core.Application
{
    public interface ICSAContext
    {
        DbSet<User> Users { get; set; }

        DbSet<Organization> Organizations { get; set; }

        DbSet<Member> Members { get; set; }

        DbSet<Account> Accounts { get; set; }

        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
    }
}
