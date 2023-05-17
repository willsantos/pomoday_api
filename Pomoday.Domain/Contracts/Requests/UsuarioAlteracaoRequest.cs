using System.ComponentModel.DataAnnotations;

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
