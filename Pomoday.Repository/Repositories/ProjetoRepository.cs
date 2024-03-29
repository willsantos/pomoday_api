﻿using Pomoday.Domain.Entities;
using Pomoday.Domain.Interfaces.Repository;
using Pomoday.Repository.Context;

namespace Pomoday.Repository.Repositories
{
    public class ProjetoRepository : BaseRepository<Projeto>, IProjetoRepository
    {
        public ProjetoRepository(PomodayContext context) : base(context)
        {
        }
    }
}
