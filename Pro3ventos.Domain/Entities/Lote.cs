using Pro3ventos.Domain.Notifications;
using Pro3ventos.Domain.Validations.Interfaces;
using Royal.Domain.Validations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Pro3ventos.Domain.Entities
{
    public sealed class Lote : BaseEntity, IContract
    {
        public Lote(string nome,
            decimal preco,
            DateTime dataTermino,
            int publicoSuportado) : base()
        {
            Nome = nome;
            Preco = preco;
            DataInicio = DateTime.UtcNow;
            DataTermino = dataTermino;
            PublicoSuportado = publicoSuportado;
        }

        public string Nome { get; private set; }
        public decimal Preco { get; private set; }
        public DateTime DataInicio { get; private set; }
        public DateTime DataTermino { get; private set; }
        public int PublicoSuportado { get; private set; }
        public Guid EventoId { get; set; }
        public Evento? Evento { get; set; }

        [NotMapped]
        public IReadOnlyCollection<Notification> _notifications => _notifications;

        public void SetLote(decimal newPreco, DateTime newDataTermino, int newPublicoSuportado)
        {
            Preco = newPreco;
            DataTermino = newDataTermino;
            PublicoSuportado = newPublicoSuportado;
        }

        public override bool IsValid()
        {
            var contracts =
                 new ContractValidations<Lote>()
                 .NomeIsOk(Nome, 10, 30, "O nome precisa ter entre 10 e 30 caracteres", "Nome Lote");


            return contracts.IsValid();
        }


    }
}