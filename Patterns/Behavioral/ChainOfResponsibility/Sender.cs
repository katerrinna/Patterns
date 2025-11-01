namespace Patterns.Behavioral.ChainOfResponsibility
{
    public class Sender
    {
        public Message WriteTextOnMessage(string message)
        {
            return new Message(){ text = message };
        }

        public Mail PutMessageOnMail(Message message)
        {
            return new Mail() { Message = message };
        }
    }
}