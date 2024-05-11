using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMS.Application.Contracts.Persistence
{
    public interface IGenericRepository<T> where T : class
    {
        T Get(int id);
        IReadOnlyList<T> GetAll();
        T Add(T entity);
        bool Exists(int id);
        void Update(T entity);
        void Delete(T entity);
    }
}
