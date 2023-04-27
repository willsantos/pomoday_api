using System.ComponentModel.DataAnnotations;

namespace Pomoday.Domain.Contracts.Requests
{
    public class UsuarioRequest : UsuarioAlteracaoRequest
    {
        [Required(ErrorMessage = "Senha do usuário é obrigatória.")]
        [StringLength(int.MaxValue, MinimumLength = 6)]
        [RegularExpression(@"^((?=.*[a-z])(?=.*[A-Z])(?=.*\d)).+$")]
        [DataType(DataType.Password)]
        public string Senha { get; set; }
    }
}
