using System;
using System.Collections.Generic;

namespace Patterns.Behavioral.Mediator
{
    public class Mediator : IPattern
    {
        public void Example()
        {
            var st = new Student(){Name = "John"};
            var th = new Teacher(){Name = "Alex"};
            
            st.SendNotice(new List<string>(){"Hi", "How are you?"});
            th.SendNotice(new List<string>(){"Hello", "It`s all ok!"});

            Console.WriteLine("Student box:");
            foreach (var m in st.GetNotice())
            {
                Console.WriteLine(m);
            }
            
            Console.WriteLine("Teacher box:");
            foreach (var m in th.GetNotice())
            {
                Console.WriteLine(m);
            }
        }
    }

    public class Student
    {
        public string Name { get; set; }

        public List<string> GetNotice()
        {
            return NoticeBoard.GetNotice(Name);
        }

        public void SendNotice(List<string> notice)
        {
            NoticeBoard.SendNotice(notice, Name);
        }
    }

    public class Teacher
    {
        public string Name { get; set; }
        
        public List<string> GetNotice()
        {
            return NoticeBoard.GetNotice(Name);
        }

        public void SendNotice(List<string> notice)
        {
            NoticeBoard.SendNotice(notice, Name);
        }
    }

    public class NoticeBoard
    {
        public static Dictionary<string, List<string>> NoticeCollection = new Dictionary<string, List<string>>();
        
        public static List<string> GetNotice(string recipientName)
        {
            return NoticeCollection[recipientName];
        }

        public static void SendNotice(List<string> notice, string recipientName)
        {
            if (NoticeCollection.TryGetValue(recipientName, out var n))
            {
                n.AddRange(notice);
            }
            else
            {
                NoticeCollection.Add(recipientName, notice);
            }
            
        }
    }
}