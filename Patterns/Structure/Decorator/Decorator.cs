using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Structure.Decorator
{
    public class Decorator : IPattern
    {
        public void Example()
        {
            Boat boat = new Boat();

            boat.Drive();
            boat.Stop();
        }
    }
}
