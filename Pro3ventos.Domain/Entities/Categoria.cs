using Pro3ventos.Domain.Notifications;
using Pro3ventos.Domain.Validations.Interfaces;
using Royal.Domain.Validations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Pro3ventos.Domain.Entities
{
    public sealed class Categoria : BaseEntity, IContract
    {
        public Categoria(string categoriaNome, string descricao)
        {
            CategoriaNome = categoriaNome;
            Descricao = descricao;
        }

        public string CategoriaNome { get; private set; }
        public string Descricao { get; private set; }

        [NotMapped]
        public IReadOnlyCollection<Notification> _notifications => _notifications;


        public void SetCategoria(string newCategoriaNome, string newDescricao)
        {
            CategoriaNome = newCategoriaNome;
            Descricao = newDescricao;

        }

        public override bool IsValid()
        {
            var contracts =
               new ContractValidations<Categoria>()
                        .NomeIsOk(CategoriaNome, 3, 15, "O nome precisa ter entre 3 e 15 caracteres", "Nome do produto")
                        .DescricaoIsOk(Descricao, 10, 300, "A descricao precisa ter ente 10 e 300 caracteres", nameof(Descricao));

            return contracts.IsValid();
        }
    }
}
