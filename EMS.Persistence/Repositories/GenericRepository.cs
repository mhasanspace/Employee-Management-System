using EMS.Application.Contracts.Persistence;
using EMS.Persistence.DatabaseContext;
using Microsoft.EntityFrameworkCore;

namespace EMS.Persistence.Repositories
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        private readonly EmsDbContext _dbContext;

        public GenericRepository(EmsDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public T Add(T entity)
        {
            _dbContext.Add(entity);
            return entity;
        }

        public void Delete(T entity)
        {
            _dbContext.Set<T>().Remove(entity);
        }

        public bool Exists(int id)
        {
            var entity = Get(id);
            return entity != null;
        }

        public T Get(int id)
        {
            return _dbContext.Set<T>().Find(id);
        }

        public IReadOnlyList<T> GetAll()
        {
            return _dbContext.Set<T>().ToList();
        }

        public void Update(T entity)
        {
            _dbContext.Entry(entity).State = EntityState.Modified;
        }
    }
}
