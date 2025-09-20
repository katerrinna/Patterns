using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Generative.AbstractFactory
{
    internal class GoOn : IMovement
    {
        public void Move()
        {
            Console.WriteLine("Поехать");
        }
    }
}
