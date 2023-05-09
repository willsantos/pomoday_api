using Pomoday.Domain.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pomoday.Domain.Entities
{
    public class Dia : BaseEntity
    {
        public StatusDias Status { get; set; }
        public virtual Usuario Usuario { get; set; }

        #region Foreign key
        public Guid UsuarioId { get; set; }
        #endregion
    }
}
