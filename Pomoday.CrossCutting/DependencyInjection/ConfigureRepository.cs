using Microsoft.Extensions.DependencyInjection;
using Pomoday.Repository.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pomoday.Domain.Interfaces.Repository;
using Pomoday.Repository.Repositories;

namespace Pomoday.CrossCutting.DependencyInjection
{
    public static class ConfigureRepository
    {
        public static void ConfigureDependenciesRepository(IServiceCollection serviceCollection, string connectionString)
        {
            serviceCollection.AddScoped<IUsuarioRepository, UsuarioRepository>();
            serviceCollection.AddScoped<IProjetoRepository, ProjetoRepository>();
            serviceCollection.AddScoped<ITarefaRepository, TarefaRepository>();
            serviceCollection.AddScoped<IRegistroRepository, RegistroRepository>();

            serviceCollection.AddDbContext<PomodayContext>(options => options.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString)));
        }
    }
}
