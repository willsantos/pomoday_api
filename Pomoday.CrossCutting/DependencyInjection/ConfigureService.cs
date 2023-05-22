using Microsoft.Extensions.DependencyInjection;
using Pomoday.Domain.Interfaces.Service;
using Pomoday.Service.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pomoday.CrossCutting.DependencyInjection
{
    public class ConfigureService
    {
        public static void ConfigureDependenciesService(IServiceCollection serviceCollection)
        {
            serviceCollection.AddScoped<IUsuarioService, UsuarioService>();
            serviceCollection.AddScoped<IProjetoService, ProjetoService>();
            serviceCollection.AddScoped<ITarefaService, TarefaService>();
        }
    }
}
