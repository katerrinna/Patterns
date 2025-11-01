using System;
using Patterns.Behavioral.ChainOfResponsibility;

namespace Patterns.Behavioral.Memento
{
    public class MementoMail: Mail
    {
        public string SaveToString()
        {
            string s = Message.text + ";" + isMarked;
            return s;
        }

        public MementoMail(string text)
        {
            string[] s = text.Split(';');
            Message = new Message()
            {
                text = s[0],
            };
            isMarked = Convert.ToBoolean(s[1]);
        }

        public MementoMail(Mail text)
        {
            this.Message = text.Message;    
            this.isMarked = text.isMarked;
        }
    }
}