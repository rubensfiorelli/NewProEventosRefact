using Pro3ventos.Domain.Notifications;
using Pro3ventos.Domain.Validations.Interfaces;
using Royal.Domain.Validations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Pro3ventos.Domain.Entities
{
    public sealed class RedeSocial : BaseEntity, IContract
    {
        public RedeSocial(string nome, string url) : base()
        {
            Nome = nome;
            Url = url;
        }

        public string Nome { get; private set; }
        public string Url { get; set; }
        public Guid EventoId { get; set; }
        public Evento? Evento { get; set; }
        public Guid PalestranteId { get; set; }
        public Palestrante? Palestrante { get; set; }

        [NotMapped]
        public IReadOnlyCollection<Notification> _notifications => _notifications;

        public void SetRedeSocial(string newNome, string newUrl)
        {
            Nome = newNome;
            Url = newUrl;

        }

        public override bool IsValid()
        {
            var contracts =
               new ContractValidations<RedeSocial>()
               .NomeIsOk(Nome, 6, 20, "O nome da rede social não eh valido", nameof(Nome))
               .UrlIsOk(Url, 60, "A URL deve ter maximo 60 caracteres", nameof(Url));


            return contracts.IsValid();
        }



    }
}