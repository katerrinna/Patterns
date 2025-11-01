using System;
using System.IO;
using System.Runtime.Serialization;
using System.Xml.Serialization;
using Patterns.Behavioral.ChainOfResponsibility;

namespace Patterns.Behavioral.Memento
{
    public class Memento : IPattern
    {
        public void Example()
        {
            var t = "Hello";
            var sender = new Sender();
            var postman = new PostMan();

            Message m = sender.WriteTextOnMessage(t);
            Mail mail = sender.PutMessageOnMail(m);

            mail = postman.MarkMail(mail);
            
            XmlSerializer serializer = new XmlSerializer(typeof(Mail));   
            
            using(StringWriter textWriter = new StringWriter())
            {
                serializer.Serialize(textWriter, mail);
                Console.WriteLine(textWriter.ToString()); 
            }

            MementoMail m1 = new MementoMail(mail);


            string s = m1.SaveToString();
            Console.WriteLine(s);    
            MementoMail m2 = new MementoMail(s);
            
            



        }
    }
}