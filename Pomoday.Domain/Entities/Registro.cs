using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pomoday.Domain.Entities
{
    public class Registro : BaseEntity
    {
        public TimeSpan? TempoGasto { get; set; }
        public virtual Tarefa? Tarefa { get; set; }

        #region Foreign key
        public Guid TarefaId { get; set; }
        #endregion
    }
}
