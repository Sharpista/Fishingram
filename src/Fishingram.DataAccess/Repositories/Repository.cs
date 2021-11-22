using Fishingram.DataAccess.Context;
using Fishingram.Domain.Interfaces.Repositories;
using Fishingram.Shared.Entities;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Fishingram.DataAccess.Repositories
{
    public abstract class Repository<TEntity> : IRepository<TEntity> where TEntity : EntityBase, new()
    {
        protected readonly FishingramContext Db;
        protected readonly DbSet<TEntity> DbSet;
        public Repository()
        {

        }
        public Repository(FishingramContext fishingramContext)
        {
            Db = fishingramContext;
            DbSet = fishingramContext.Set<TEntity>();
        }
        public virtual async Task<IEnumerable<TEntity>> GetAll()
        {
            return await DbSet.ToListAsync();
        }

        public virtual async Task<TEntity> GetById(long id)
        {
            return await DbSet.AsNoTracking().SingleOrDefaultAsync(_ => _.Id == id);
        }

        public virtual async Task Add(TEntity entity)
        {
            DbSet.Add(entity);

            await SaveChanges();
        }
        public virtual async Task Put(TEntity entity)
        {
            DbSet.Update(entity);

            await SaveChanges();
        }

        public virtual async Task Delete(long id)
        {
            DbSet.Remove(new TEntity { Id = id });
            await SaveChanges();
        }
        public virtual async Task<int> SaveChanges()
        {
            return await Db.SaveChangesAsync();
        }
        public void Dispose()
        {
            Db?.Dispose();
        }
    }
}
