using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pomoday.Domain.Entities
{
    public class BaseEntity
    {
        public BaseEntity()
        {
            Ativo = true;
            Id = new Guid();
        }

        public Guid Id { get; set; }
        public bool Ativo { get; set; }
        public DateTime CriadoEm { get; set; }
        public DateTime? AlteradoEm { get; set; }
        public DateTime? DeletadoEm { get; set; }
    }
}
