using Pomoday.Domain.Interfaces.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Pomoday.Repository.Repositories
{
    public class BaseRepository<T> : IBaseRepository<T> where T : class
    {
        public Task AddAsync(T item)
        {
            throw new NotImplementedException();
        }

        public Task EditAsync(T item)
        {
            throw new NotImplementedException();
        }

        public Task<T> FindAsNoTrackingAsync(Expression<Func<T, bool>> expression)
        {
            throw new NotImplementedException();
        }

        public Task<T> FindAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<T> FindAsync(Expression<Func<T, bool>> expression)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<T>> ListAsync()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<T>> ListAsync(Expression<Func<T, bool>> expression)
        {
            throw new NotImplementedException();
        }

        public Task RemoveAsync(T item)
        {
            throw new NotImplementedException();
        }
    }
}
