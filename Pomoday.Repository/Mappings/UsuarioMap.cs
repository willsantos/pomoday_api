using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Pomoday.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Objects.DataClasses;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
