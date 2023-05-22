using Microsoft.Extensions.DependencyInjection;
using Pomoday.CrossCutting.Mappers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pomoday.CrossCutting.DependencyInjection
{
    public class ConfigureMappers
    {
        public static void ConfigureDependenciesMapper(IServiceCollection serviceCollection)
        {
            var config = new AutoMapper.MapperConfiguration(cnf =>
            {
                cnf.AddProfile(new UsuarioToContractMap());
                cnf.AddProfile(new ProjetoToContractMap());
                cnf.AddProfile(new TarefaToContractMap());
                cnf.AddProfile(new RegistroToContractMap());
            });
            var mapConfiguration = config.CreateMapper();
            serviceCollection.AddSingleton(mapConfiguration);
        }
    }
}
