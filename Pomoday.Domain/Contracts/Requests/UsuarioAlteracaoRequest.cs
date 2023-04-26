using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pomoday.Domain.Contracts.Requests
{
    public class UsuarioAlteracaoRequest
    {
        [Required(ErrorMessage = "Nome do usuário é obrigatório.")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Email é obrigatório.")]
        [DataType(DataType.EmailAddress)]

        public string Email { get; set; }
    }
}
