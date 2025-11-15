using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Behavioral.Observer
{
    public class NewsChannel
    {
        public List<ISubscriber> subscribers = new List<ISubscriber>();
        public void AddSubscriber(ISubscriber subscriber)
        {
            subscribers.Add(subscriber);
        }

        public void RemoveSubscriber(ISubscriber subscriber)
        {
            subscribers.Remove(subscriber);
        }

        public void SendNotification(string notification)
        {
            foreach (ISubscriber subscriber in subscribers)
            {
                subscriber.GetNotification(notification);
            }
        }
    }
}
