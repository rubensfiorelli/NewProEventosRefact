using Pro3ventos.Domain.Notifications;
using Pro3ventos.Domain.Validations.Interfaces;
using Royal.Domain.Validations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Pro3ventos.Domain.Entities
{
    public sealed class Palestrante : BaseEntity, IContract
    {
        public Palestrante(string nome,
                           string bio,
                           string imgUrl,
                           string whatsApp,
                           string email,
                           string sobrenome) : base()
        {
            Nome = nome;
            Bio = bio;
            ImgUrl = imgUrl;
            WhatsApp = whatsApp;
            Email = email;
            Sobrenome = sobrenome;
        }

        public string Nome { get; private set; }
        public string Sobrenome { get; private set; }
        public string Bio { get; private set; }
        public string ImgUrl { get; private set; }
        public string WhatsApp { get; private set; }
        public string Email { get; private set; }
        public List<RedeSocial>? RedesSociais { get; set; }
        public List<Evento>? Eventos { get; set; }

        [NotMapped]
        public IReadOnlyCollection<Notification> _notifications => _notifications;


        public void SetPalestrante(string newNome, string newSobreNome, string newBio, string newImgUrl, string newWhatsApp, string newEmail)
        {
            Nome = newNome;
            Sobrenome = newSobreNome;
            Bio = newBio;
            ImgUrl = newImgUrl;
            WhatsApp = newWhatsApp;
            Email = newEmail;
        }

        public override bool IsValid()
        {
            var contracts =
                new ContractValidations<Palestrante>()
                .PrimeiroNomeIsOk(Nome, 4, 15, "O nome precisa ter entre 4 e 15 caracteres", nameof(Nome))
                .SobreNomeIsOk(Sobrenome, 10, 30, "O sobrenome deve ter entre 10 e 30 caracteres", nameof(Sobrenome));


            return contracts.IsValid();
        }

    }
}