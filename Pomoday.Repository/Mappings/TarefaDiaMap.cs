using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Pomoday.Domain.Entities;

namespace Pomoday.Repository.Mappings
{
    public class TarefaDiaMap
    {
        public void Configure(EntityTypeBuilder<TarefaDia> builder)
        {
            builder.HasOne(prop => prop.Dia)
                .WithMany()
                .HasForeignKey(prop => prop.DiaId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(prop => prop.Tarefa)
                .WithMany()
                .HasForeignKey(prop => prop.TarefaId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
