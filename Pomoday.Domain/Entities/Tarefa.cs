using Pomoday.Domain.Utils;

namespace Pomoday.Domain.Entities
{
    public class Tarefa : BaseEntity
    {
        public DateTime Prazo { get; set; }
        public DateTime Agendada { get; set; }
        public TimeSpan? TempoGasto { get; set; }
        public EnumStatus Status { get; set; }
        public EnumPrioridadeTarefa Prioridade { get; set; }
        public virtual Usuario Usuario { get; set; }
        public virtual Projeto? Projeto { get; set; }
        public ICollection<Registro> Registros { get; set; }

        #region Foreign key
        public Guid UsuarioId { get; set; }
        public Guid ProjetoId { get; set; }
        #endregion
    }
}
