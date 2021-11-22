using Fishingram.Shared.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Fishingram.Domain.Interfaces.Services
{
    public interface IServiceBase<T> : IDisposable where T : EntityBase
    {
        Task Add(T entity);
        Task<T> GetById(long id);
        Task<IEnumerable<T>> GetAll();
        Task Put(T entity);
        Task Delete(long id);
    }
}
