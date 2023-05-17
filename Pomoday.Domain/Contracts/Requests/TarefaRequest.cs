using Pomoday.Domain.Utils;

namespace Pomoday.Domain.Contracts.Requests
{
    public class TarefaRequest
    {
        public string Nome { get; set; }
        public DateTime? Prazo { get; set; }
        public DateTime? Agendada { get; set; }
        public TimeSpan? TempoGasto { get; set; }
    }
}
