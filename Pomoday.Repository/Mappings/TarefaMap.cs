using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Pomoday.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pomoday.Repository.Mappings
{
    public class TarefaMap
    {
        public void Configure(EntityTypeBuilder<Tarefa> builder)
        {
            builder.HasOne(prop => prop.Usuario)
                .WithMany(prop => prop.Tarefas)
                .HasForeignKey(prop => prop.UsuarioId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(prop => prop.Projeto)
                .WithMany(prop => prop.Tarefas)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
