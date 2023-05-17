using Pomoday.Domain.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pomoday.Domain.Contracts.Requests
{
    public class ProjetoRequest
    {
        public string Nome { get; set; }
        public EnumStatus Status { get; set; }
        public DateTime? Prazo { get; set; }
        public Guid UsuarioId { get; set; }
    }
}
