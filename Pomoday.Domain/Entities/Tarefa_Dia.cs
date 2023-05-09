using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pomoday.Domain.Entities
{
    public class Tarefa_Dia
    {
        public Guid Id { get; set; }
        public virtual Dia Dia{ get; set; }
        public virtual Projeto Projeto { get; set; }

        #region Foreign key
        public Guid DiaId { get; set; }
        public Guid ProjetoId { get; set; }
        #endregion
    }
}
