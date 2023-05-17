namespace Pomoday.Domain.Contracts.Requests
{
    public class RegistroRequest
    {
        public TimeSpan? TempoGasto { get; set; }
        public Guid TarefaId { get; set; }
    }
}
