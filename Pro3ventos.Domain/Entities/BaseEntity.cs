using Pro3ventos.Domain.Notifications;
using Pro3ventos.Domain.Validations.Interfaces;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Pro3ventos.Domain.Entities
{
    public abstract class BaseEntity : IValidate
    {

        private List<Notification>? _notifications;

        protected BaseEntity()
        {
            Id = Guid.NewGuid();
        }

        [Key]
        public Guid Id { get; protected set; }

        private DateTime _createAt;

        public DateTime CreateAt
        {
            get { return _createAt; }
            set => _createAt = DateTime.UtcNow;
        }

        private DateTime _updateAt;

        public DateTime UpdateAt
        {
            get { return _updateAt; }
            set { _updateAt = value; }
        }

        public abstract bool IsValid();


        [NotMapped]
        public IReadOnlyCollection<Notification>? Notifications => _notifications;

        protected void SetNotifications(List<Notification> notifications)
        {
            _notifications = notifications;
        }
    }
}
