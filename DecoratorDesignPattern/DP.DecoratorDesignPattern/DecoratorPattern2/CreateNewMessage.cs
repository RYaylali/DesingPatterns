using DP.DecoratorDesignPattern.DAL;

namespace DP.DecoratorDesignPattern.DecoratorPattern2
{
    public class CreateNewMessage : ISendMesssage
    {
        Context context = new Context();
        public void SendMesssage(Message message)
        {
            context.Messages.Add(message);
            context.SaveChanges();
        }
    }
}
