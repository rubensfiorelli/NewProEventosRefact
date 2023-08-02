using Pro3ventos.Domain.Notifications;
using Pro3ventos.Domain.Validations.Interfaces;
using System.ComponentModel.DataAnnotations.Schema;

namespace Pro3ventos.Domain.Entities
{
    public sealed class ValorIngresso : BaseEntity, IContract
    {
        public ValorIngresso(decimal valor)
        {
            Valor = 350;
        }

        public decimal Valor { get; private set; }

        [NotMapped]
        public IReadOnlyCollection<Notification> _notifications => _notifications;

        public override bool IsValid()
        {
            throw new NotImplementedException();
        }
    }
}
