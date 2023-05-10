using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pomoday.Domain.Entities
{
    public class Projeto : BaseEntity
    {
        public string Nome { get; set; }
        public DateTime? Prazo{ get; set; }
        public float Progresso{ get; set; }
        public virtual Usuario Usuario { get; set; }
        public ICollection<Tarefa> Tarefas { get; set; }

        #region Foreign key
        public Guid UsuarioId { get; set; }
        #endregion

    }
}
