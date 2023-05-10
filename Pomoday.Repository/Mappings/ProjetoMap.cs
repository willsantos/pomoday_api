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
    public class ProjetoMap
    {
        public void Configure(EntityTypeBuilder<Projeto> builder)
        {
            builder.HasOne(prop => prop.Usuario)
                .WithMany(prop => prop.Projetos)
                .HasForeignKey(prop => prop.UsuarioId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
