using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Pomoday.Domain.Entities;

namespace Pomoday.Repository.Mappings
{
    public class DiaMap
    {
        public void Configure(EntityTypeBuilder<Dia> builder)
        {
            builder.HasOne(prop => prop.Usuario)
                .WithMany(prop => prop.Dias)
                .HasForeignKey(prop => prop.UsuarioId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
