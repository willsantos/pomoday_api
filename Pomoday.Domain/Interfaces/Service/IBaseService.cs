﻿using Pomoday.Domain.Contracts.Requests;
using Pomoday.Domain.Contracts.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Pomoday.Domain.Interfaces.Service
{
    public interface IBaseService<Request, Response>
    {
        Task<Response> CriarAsync(Request request);
        Task<Response> AtualizarAsync(Guid? id, Request request);
        Task DeletarAsync(Guid id);
        Task<Response> ObterPorIdAsync(Guid id);
        Task<IEnumerable<Response>> ObterTodosAsync();
    }
}
