using Projeto.Balta.MaoNaMassa.NotificationContext;

namespace Projeto.Balta.MaoNaMassa.NotificantionContext
{
    public class Base : Notifiable
    {
        public Base()
        {
            Id = Guid.NewGuid();
        }

        public Guid Id { get; set; }
    }
}