using Pomoday.Domain.Contracts.Requests;
using Pomoday.Domain.Contracts.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pomoday.Domain.Interfaces.Service
{
    public interface ITarefaService : IBaseService<TarefaRequest, TarefaResponse>
    {
    }
}
