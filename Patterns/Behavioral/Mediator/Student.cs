using System.Collections.Generic;

namespace Patterns.Behavioral.Mediator
{
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
}