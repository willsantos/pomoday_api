using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pomoday.Domain.Entities
{
    public class TarefaDia
    {
        public Guid Id { get; set; }
        public virtual Dia Dia{ get; set; }
        public virtual Tarefa Tarefa { get; set; }

        #region Foreign key
        public Guid DiaId { get; set; }
        public Guid TarefaId { get; set; }
        #endregion
    }
}
