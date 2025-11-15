using System;

namespace Patterns.Behavioral.ChainOfResponsibility
{
    /// <summary>
    /// Этот паттерн предполагает под собой определённую последовательность действий преобразования одного объекта в другой
    /// </summary>
    public class ChainOfResponsibility: IPattern
    {
        public void Example()
        {
            var t = "Hello";
            var sender = new Sender();
            var postman = new PostMan();

            Message m = sender.WriteTextOnMessage(t);
            Mail mail = sender.PutMessageOnMail(m);

            mail = postman.MarkMail(mail);
            
            Console.WriteLine($"{mail.Message.text} and mark is {mail.isMarked}");
        }
    }
}