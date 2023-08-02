using Pro3ventos.Domain.Notifications;

namespace Royal.Domain.Validations
{
    public partial class ContractValidations<T>
    {
        public ContractValidations<T> PrimeiroNomeIsOk(string nome, short maxLength, short minLength, string message, string propertyName)
        {
            if (string.IsNullOrEmpty(nome) || (nome.Length < minLength) || (nome.Length > maxLength))

                AddNotification(new Notification(message, propertyName));

            return this;
        }

        public ContractValidations<T> SobreNomeIsOk(string sobreNome, short maxLength, short minLength, string message, string propertyName)
        {
            if (string.IsNullOrEmpty(sobreNome) || (sobreNome.Length < minLength) || (sobreNome.Length > maxLength))

                AddNotification(new Notification(message, propertyName));

            return this;
        }
    }
}
