using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Generative.AbstractFactory
{
    internal class SwordSwing : IHit
    {
        public void Hit()
        {
            Console.WriteLine("Удар мечом");
        }
    }
}
