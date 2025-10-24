using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Structure.Decorator
{
    public class BoatEngine : IBoost
    {
        public void Boost()
        {
            Console.WriteLine("Boost");
        }
    }
}
