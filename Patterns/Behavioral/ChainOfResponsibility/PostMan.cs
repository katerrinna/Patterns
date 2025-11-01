namespace Patterns.Behavioral.ChainOfResponsibility
{
    public class PostMan
    {
        public Mail MarkMail(Mail mail)
        {
            mail.isMarked = true;
            return mail;
        }
    }
}