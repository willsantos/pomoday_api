using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pomoday.Domain.Utils
{
    public static class ConstanteUtil
    {
        public const string PerfilColaborador = "Colaborador";
        public const string PerfilAdministrador = "Administrador";
        public const string PerfilLogadoNome = $"{PerfilColaborador}, {PerfilAdministrador}";
    }
}
