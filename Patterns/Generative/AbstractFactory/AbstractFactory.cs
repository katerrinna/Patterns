using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Generative.AbstractFactory
{
    /// <summary>
    /// Этот паттерн предполагает под собой класс, инициализирующий объекты других классов, у которых методы могут иметь разные реализации в зависимости от интерфейсов, передаваемых в инициализирующий класс
    /// </summary>
    public class AbstractFactory : IPattern
    {
        public void Example() {
            Hero warior1 = HeroFactory.createWarior();
            Hero ranger1 = HeroFactory.createRanger();

            warior1.Hit();
            warior1.Move();

            ranger1.Hit();
            ranger1.Move();
        }
    }
}
