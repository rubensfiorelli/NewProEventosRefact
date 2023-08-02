using Pro3ventos.Domain.Notifications;
using Pro3ventos.Domain.Validations.Interfaces;
using Royal.Domain.Validations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Pro3ventos.Domain.Entities
{
    public sealed class Evento : BaseEntity, IContract
    {
        public Evento(string nome,
            string local,
            DateTime dataTermino,
            string imgUrl,
            string whatsApp,
            string email) : base()
        {
            Nome = nome;
            Local = local;
            DataInicio = DateTime.UtcNow;
            DataTermino = dataTermino;
            ImgUrl = imgUrl;
            WhatsApp = whatsApp;
            Email = email;
            Lotes = new();
            RedesSociais = new();
            Palestrantes = new();
        }

        public string Nome { get; private set; }
        public string Local { get; private set; }
        public DateTime DataInicio { get; private set; }
        public DateTime DataTermino { get; private set; }
        public string ImgUrl { get; private set; }
        public string WhatsApp { get; private set; }
        public string Email { get; private set; }
        public List<Lote> Lotes { get; set; }
        public List<RedeSocial> RedesSociais { get; set; }
        public List<Palestrante> Palestrantes { get; set; }


        [NotMapped]
        public IReadOnlyCollection<Notification> _notifications => _notifications;

        public void SetEvento(string newLocal,
            DateTime newDataInicio,
            DateTime newDataTermino,
            string newImgUrl,
            string newWhatsApp,
            string NewEmail)
        {
            Local = newLocal;
            DataInicio = newDataInicio;
            DataTermino = newDataTermino;
            ImgUrl = newImgUrl;
            WhatsApp = newWhatsApp;
            Email = NewEmail;

        }

        public override bool IsValid()
        {
            var contracts =
                new ContractValidations<Evento>()
                .NomeIsOk(Nome, 3, 15, "O nome precisa ter entre 3 e 15 caracteres", "Nome do produto");


            return contracts.IsValid();
        }

    }
}
