using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Persistence
{
    public class DbContextContainer
    {
        public IEnumerable<DbContext> Contexts { get; set; }
    }
    public interface IUnitOfWork
    {
        Task SaveChangesAsync();
    }

    public class UnitOfWork : IUnitOfWork
    {
        private readonly DbContextContainer _dbContextContainer;
        public UnitOfWork(DbContextContainer dbContextContainer)
        {
            _dbContextContainer = dbContextContainer;
        }

        public async Task SaveChangesAsync()
        {
            foreach (var dbContext in _dbContextContainer.Contexts)
            {
                await dbContext.SaveChangesAsync();
            }
        }
    }
}
