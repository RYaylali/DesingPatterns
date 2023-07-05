using DP.DecoratorDesignPattern.DAL;
using DP.DecoratorDesignPattern.DecoratorPattern;

namespace DP.DecoratorDesignPattern.DecoratorPattern2
{
    public class Decorator : ISendMesssage
    {
        private readonly ISendMesssage _send;

        public Decorator(ISendMesssage sendMesssage)
        {
            _send = sendMesssage;
        }

        public virtual void SendMesssage(Message message)
        {
            message.MessageReceiver = "Everyone";
            message.MessageSender = "Admin";
            message.MessageSubject = "Toplantı";
            message.MessageContent = "Toplantı";
            _send.SendMesssage(message);
        }
    }
}
