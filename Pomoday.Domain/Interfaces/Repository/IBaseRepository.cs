using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Pomoday.Domain.Interfaces.Repository
{
    public interface IBaseRepository<T> where T : class
    {
        Task<T> FindAsync(Guid id);
        Task<T> FindAsync(Expression<Func<T, bool>> expression);
        Task<T> FindAsNoTrackingAsync(Expression<Func<T, bool>> expression);
        Task<IEnumerable<T>> ListAsync();
        Task<IEnumerable<T>> ListAsync(Expression<Func<T, bool>> expression);
        Task AddAsync(T item);
        Task RemoveAsync(T item);
        Task EditAsync(T item);
    }
}
