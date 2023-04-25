using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Pomoday.Domain.Interfaces.Service
{
    public interface IBaseService<T>
    {
        Task<IEnumerable<T>> ObterTodosAsync(Expression<Func<T, bool>> expression);
        Task<T> ObterAsync(Expression<Func<T, bool>> expression);
        Task<IEnumerable<T>> ObterTodosAsync();
        Task<T> ObterPorIdAsync(Guid id);
        Task<T> AdicionarAsync(T entity);
        Task DeletarAsync(Guid id);
        Task AlterarAsync(T entity);
    }
}
