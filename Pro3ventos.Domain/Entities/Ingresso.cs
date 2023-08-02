using Pro3ventos.Domain.Enums;
using Pro3ventos.Domain.Notifications;
using Pro3ventos.Domain.Validations.Interfaces;
using Royal.Domain.Validations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Pro3ventos.Domain.Entities
{
    public sealed class Ingresso : BaseEntity, IContract
    {
        public Ingresso(string loteId, Guid valorIngressoId, string nome, string sobreNome, string email, string whatsApp)
        {
            Tipo = ETipoIngresso.CampuseiroPresencialSemCamping;
            LoteId = loteId;
            ValorIngressoId = valorIngressoId;
            Nome = nome;
            SobreNome = sobreNome;
            Email = email;
            WhatsApp = whatsApp;
        }

        public ETipoIngresso Tipo { get; private set; }
        public string LoteId { get; private set; }
        public Guid ValorIngressoId { get; private set; }
        public string Nome { get; private set; }
        public string SobreNome { get; private set; }
        public string Email { get; private set; }
        public string WhatsApp { get; private set; }


        public void SetIngresso(ETipoIngresso newTipo, string newNome, string newSobreNome, string newEmail,
                                string newWhatsApp)
        {
            Tipo = newTipo;
            Nome = newNome;
            SobreNome = newSobreNome;
            Email = newEmail;
            WhatsApp = newWhatsApp;
        }


        [NotMapped]
        public IReadOnlyCollection<Notification> _notifications => _notifications;

        public override bool IsValid()
        {
            var contracts =
                 new ContractValidations<Ingresso>()
                 .EmailIsOk(Email, "Forneca um email valido", nameof(Email));

            return contracts.IsValid();
        }
    }
}
