using Pomoday.Domain.Entities;
using Pomoday.Domain.Interfaces.Repository;
using Pomoday.Repository.Context;

namespace Pomoday.Repository.Repositories
{
    public class RegistroRepository : BaseRepository<Registro>, IRegistroRepository
    {
        public RegistroRepository(PomodayContext context) : base(context)
        {
        }
    }
}
