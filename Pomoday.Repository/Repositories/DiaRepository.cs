using Pomoday.Domain.Entities;
using Pomoday.Domain.Interfaces.Repository;
using Pomoday.Repository.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pomoday.Repository.Repositories
{
    public class DiaRepository : BaseRepository<Dia>, IDiaRepository
    {
        public DiaRepository(PomodayContext context) : base(context)
        {
        }
    }
}
