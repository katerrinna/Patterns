using System;
using System.Collections.Generic;

namespace Patterns.Behavioral.Mediator
{
    /// <summary>
    /// Этот паттерн предполагает под собой наличие объекта класса или статического класса (NoticeBoard), который соединяет 2 независимые друг от друга компоненты кода (Student и Teacher)
    /// </summary>
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
}