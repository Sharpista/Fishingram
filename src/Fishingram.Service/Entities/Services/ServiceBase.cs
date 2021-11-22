using Fishingram.Domain.Interfaces.Repositories;
using Fishingram.Domain.Interfaces.Services;
using Fishingram.Shared.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Fishingram.Service.Entities.Services
{
    public class ServiceBase<TEntity> : IServiceBase<TEntity> where TEntity : EntityBase
    {
        private readonly IRepository<TEntity> _repository;

        public ServiceBase(IRepository<TEntity> repository)
        {
            _repository = repository;
        }

        public virtual async Task<IEnumerable<TEntity>> GetAll()
        {
            return await _repository.GetAll();
        }

        public virtual async Task<TEntity> GetById(long id)
        {
            return await _repository.GetById(id);
        }

        public virtual async Task Add(TEntity entity)
        {
            await _repository.Add(entity);
        }

        public virtual async Task Put(TEntity entity)
        {
            await _repository.Put(entity);
        }
        public virtual async Task Delete(long id)
        {
            await _repository.Delete(id);
        }

        public void Dispose()
        {
            _repository?.Dispose();
        }
    }
}
