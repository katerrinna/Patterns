using System.Collections.Generic;

namespace Patterns.Behavioral.Mediator
{
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