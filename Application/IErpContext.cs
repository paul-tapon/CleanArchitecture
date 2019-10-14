using Core.Domain.Model.Entities.Common;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Core.Application
{
    public interface ICommonContext
    {
        DbSet<User> Users { get; set; }

        DbSet<Organization> Organizations { get; set; }

        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
    }
}
