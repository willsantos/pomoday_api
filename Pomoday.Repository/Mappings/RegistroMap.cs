using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using Pomoday.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pomoday.Repository.Mappings
{
    public class RegistroMap
    {
        public void Configure(EntityTypeBuilder<Registro> builder)
        {
            builder.HasOne(prop => prop.Tarefa)
                .WithMany(prop => prop.Registros)
                .HasForeignKey(prop => prop.TarefaId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
