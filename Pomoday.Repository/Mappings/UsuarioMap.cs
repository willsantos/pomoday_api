using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Pomoday.Domain.Entities;

namespace Pomoday.Repository.Mappings
{
    public class UsuarioMap
    {
        public void Configure(EntityTypeBuilder<Usuario> builder)
        {
            builder.HasIndex(prop => prop.Email).IsUnique();
        }
    }
}
