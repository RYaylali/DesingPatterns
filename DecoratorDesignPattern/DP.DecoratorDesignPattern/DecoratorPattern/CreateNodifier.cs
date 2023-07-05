using DP.DecoratorDesignPattern.DAL;

namespace DP.DecoratorDesignPattern.DecoratorPattern
{
    public class CreateNodifier : INotifier
    {
        //Yapılan işlemlerin veri tabanına kayıt işlemi yapılır
        Context context = new Context();
        public void CreateNotify(Notifier notifier)
        {
            context.Notifiers.Add(notifier);
            context.SaveChanges();
        }
    }
}
