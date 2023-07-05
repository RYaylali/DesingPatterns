using DP.DecoratorDesignPattern.DAL;

namespace DP.DecoratorDesignPattern.DecoratorPattern2
{
    public class EncryptoBySubjectDecorator : Decorator
    {
        private readonly ISendMesssage _sendMesssage;
        Context context = new Context();
        public EncryptoBySubjectDecorator(ISendMesssage sendMesssage) : base(sendMesssage)
        {
            _sendMesssage = sendMesssage;
        }
        public void SendMessageByEncryptoSubject(Message message)
        {
            message.MessageSender = "İK";
            message.MessageReceiver = "İT";
            message.MessageContent = "12:00";
            string data = "";
            data = message.MessageSubject;
            char[] chars = data.ToCharArray();
            foreach (var item in chars)
            {
                message.MessageSubject += Convert.ToChar(item + 3).ToString();
            }
            context.Messages.Add(message);
            context.SaveChanges();
        }
        public override void SendMesssage(Message message)
        {
            base.SendMesssage(message);
            SendMessageByEncryptoSubject(message);
        }
    }
}
