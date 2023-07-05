using DP.DecoratorDesignPattern.DAL;

namespace DP.DecoratorDesignPattern.DecoratorPattern2
{
    public class SubjectIDDecorator : Decorator
    {
        private readonly ISendMesssage _sendMessage;
        Context context = new Context();
        public SubjectIDDecorator(ISendMesssage sendMessage) : base(sendMessage)
        {
            _sendMessage = sendMessage;
        }
        public void SendMessageIDSubject(Message message)
        {
            if (message.MessageSubject == "1")
            {
                message.MessageSubject = "Toplantı";
            }
            if (message.MessageSubject == "2")
            {
                message.MessageSubject = "Scrum Toplantısı";
            }
            if (message.MessageSubject == "3")
            {
                message.MessageSubject = "Haftalık Değerlendirme";
            }
            context.Messages.Add(message);
            context.SaveChanges();
        }
        public override void SendMesssage(Message message)
        {
            base.SendMesssage(message);
            SendMessageIDSubject(message);
        }
    }
}
