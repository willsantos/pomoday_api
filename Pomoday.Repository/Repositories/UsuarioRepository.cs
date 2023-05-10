using Pomoday.Domain.Entities;
using Pomoday.Domain.Interfaces.Repository;
using Pomoday.Repository.Context;

namespace Pomoday.Repository.Repositories
{
    public class UsuarioRepository : BaseRepository<Usuario>, IUsuarioRepository
    {
        public UsuarioRepository(PomodayContext context) : base(context)
        {
        }
    }
}
