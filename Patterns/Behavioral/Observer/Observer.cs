using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Behavioral.Observer
{
    /// <summary>
    /// Этот паттерн предполагает под собой вызов метода группы классов (в данном случае реализующих интерфейс ISubscriber) при вызове метода одного управляющего класса (NewsChannel)
    /// </summary>
    public class Observer : IPattern
    {
        public void Example()
        {
            NewsChannel newsChannel = new NewsChannel();
            Subscriber subscriber1 = new Subscriber("0");
            Subscriber subscriber2 = new Subscriber("1");
            subscriber1.Subscribe(newsChannel);
            subscriber2.Subscribe(newsChannel);
            newsChannel.SendNotification("новость");
        }
    }
}
