using Microsoft.Extensions.DependencyInjection;
using Pomoday.Repository.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pomoday.CrossCutting.DependencyInjection
{
    public static class ConfigureRepository
    {
        public static void ConfigureDependenciesRepository(IServiceCollection serviceCollection, string connectionString)
        {
            serviceCollection.AddDbContext<PomodayContext>(options => options.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString)));
        }
    }
}
