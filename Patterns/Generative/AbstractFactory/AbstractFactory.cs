using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Generative.AbstractFactory
{
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
