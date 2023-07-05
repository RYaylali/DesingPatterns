using DP.DecoratorDesignPattern.DAL;

namespace DP.DecoratorDesignPattern.DecoratorPattern2
{
    public class EncrptoByContentDecarator : Decorator
    {
        private readonly ISendMesssage _sendMesssage;
        Context context = new Context();
        public EncrptoByContentDecarator(ISendMesssage sendMesssage) : base(sendMesssage)
        {
            _sendMesssage = sendMesssage;
        }
        public void SendMessageByEncryptoContent(Message message)
        {
            message.MessageSender = "TL";
            message.MessageReceiver = "İT";
            message.MessageContent = "10:00";
            message.MessageSubject = "Publish";
            string data = "";
            data = message.MessageContent;
            char[] chars = data.ToCharArray();
            foreach (var item in chars)
            {
                message.MessageContent += Convert.ToChar(item + 3).ToString();
            }
            context.Messages.Add(message);
            context.SaveChanges();
        }
        public override void SendMesssage(Message message)
        {
            base.SendMesssage(message);
            SendMessageByEncryptoContent(message);
        }
    }
}
