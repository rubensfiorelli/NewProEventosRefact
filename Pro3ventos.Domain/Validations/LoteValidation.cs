using Pro3ventos.Domain.Notifications;

namespace Royal.Domain.Validations
{
    public partial class ContractValidations<T>
    {
        public ContractValidations<T> LoteIsOk(string lote, short minLength, string message, string propertyName)
        {
            if (string.IsNullOrEmpty(lote) || (lote.Length < minLength))

                AddNotification(new Notification(message, propertyName));

            return this;
        }
    }
}
