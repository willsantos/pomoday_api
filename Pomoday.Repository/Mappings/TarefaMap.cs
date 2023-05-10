using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Pomoday.Domain.Entities;

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
