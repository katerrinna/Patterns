using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Behavioral.Observer
{
    public class Subscriber : ISubscriber
    {
        public string Id;

        public Subscriber(string id)
        {
            Id = id;
        }

        public override bool Equals(object obj)
        {
            return Id.Equals(((Subscriber)obj).Id);
        }

        public void GetNotification(string notification)
        {
            Console.WriteLine(notification);
        }

        public void Subscribe(NewsChannel newsChannel)
        {
            newsChannel.AddSubscriber(this);
        }

        public void Unsubscribe(NewsChannel newsChannel)
        {
            newsChannel.RemoveSubscriber(this);
        }
    }
}
