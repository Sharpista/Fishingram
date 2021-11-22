using Fishingram.Shared.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Fishingram.Domain.Interfaces.Repositories
{
    public interface IRepository<TEntity> : IDisposable where TEntity : EntityBase
    {
        Task Add(TEntity entity);
        Task<TEntity> GetById(long id);
        Task<IEnumerable<TEntity>> GetAll();
        Task Put(TEntity entity);
        Task Delete(long id);
        Task<int> SaveChanges();
    }
}
