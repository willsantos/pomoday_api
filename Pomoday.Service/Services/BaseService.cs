using Microsoft.AspNetCore.Http;
using Pomoday.Domain.Entities;
using Pomoday.Domain.Interfaces.Repository;
using Pomoday.Domain.Interfaces.Service;
using System.Linq.Expressions;

namespace Pomoday.Service.Services
{
    public class BaseService
    {
        //private readonly IBaseRepository<T> _repository;
        //public readonly Guid? UsuarioId;
        //public readonly string UsuarioPermissao;

        //public BaseService(IBaseRepository<T> repository, IHttpContextAccessor httpContextAccessor)
        //{
        //    _repository = repository;
        //    //UsuarioId = httpContextAccessor.HttpContext.GetClaim(ClaimTypes.NameIdentifier).ToGuid();
        //    //UsuarioPermissao = httpContextAccessor.HttpContext.GetClaim(ClaimTypes.Role);
        //}

        //public async Task<T> AdicionarAsync(T entity)
        //{
        //    entity.CriadoEm = DateTime.Now;
        //    await _repository.AddAsync(entity);
        //    return entity;
        //}

        //public async Task<IEnumerable<T>> ObterTodosAsync(Expression<Func<T, bool>> expression)
        //{
        //    return await _repository.ListAsync(expression);
        //}

        //public async Task<T> ObterAsync(Expression<Func<T, bool>> expression)
        //{
        //    var entity = await _repository.FindAsync(expression);
        //    if (entity == null)
        //        throw new ArgumentException("Nenhum dado encontrado.");
        //    return entity;
        //}

        //public async Task<IEnumerable<T>> ObterTodosAsync()
        //{
        //    return await _repository.ListAsync(x => x.Ativo);
        //}

        //public async Task<T> ObterPorIdAsync(Guid id)
        //{
        //    var entity = await _repository.FindAsync(x => x.Id == id && x.Ativo);
        //    if (entity == null)
        //        throw new ArgumentException($"Nenhum dado encontrado para o Id {id}");
        //    return entity;
        //}

        //public async Task DeletarAsync(Guid id)
        //{
        //    var entity = await _repository.FindAsync(id);
        //    if (entity == null)
        //        throw new ArgumentException($"Nenhum dado encontrado para o Id {id}");
        //    entity.DeletadoEm = DateTime.Now;
        //    entity.Ativo = false;
        //    await _repository.EditAsync(entity);
        //}

        //public async Task AlterarAsync(T entity)
        //{
        //    var find = await _repository.FindAsNoTrackingAsync(x => x.Id == entity.Id && x.Ativo);
        //    if (find == null)
        //        throw new ArgumentException($"Nenhum dado encontrado para o Id {entity.Id}");
        //    entity.CriadoEm = find.CriadoEm;
        //    entity.AlteradoEm = DateTime.Now;
        //    await _repository.EditAsync(entity);
        //}

    }
}
