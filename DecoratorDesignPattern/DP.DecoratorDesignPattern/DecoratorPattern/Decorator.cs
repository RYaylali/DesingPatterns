using DP.DecoratorDesignPattern.DAL;

namespace DP.DecoratorDesignPattern.DecoratorPattern
{
    public class Decorator : INotifier//default bildirim oluşturma sınıfı 
    {
        //özelleştirme işlemlerinin yapıldığı yer
        Context context =new Context();
        private readonly INotifier _notifier;

        public Decorator(INotifier notifier)
        {
            _notifier = notifier;
        }

        public virtual void CreateNotify(Notifier notifier)
        {
            notifier.NotifierCreator = "Admin";
            notifier.NotifierSubject = "Toplantı";
            notifier.NotifierType = "Public";
            notifier.NotifierChannel = "Whatsapp";
            _notifier.CreateNotify(notifier);
        }
    }
}
