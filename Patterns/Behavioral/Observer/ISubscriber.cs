using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Behavioral.Observer
{
    public interface ISubscriber
    {
        void Subscribe(NewsChannel newsChannel);
        void Unsubscribe(NewsChannel newsChannel);
        void GetNotification(string notification);
    }
}
