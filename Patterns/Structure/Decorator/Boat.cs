using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Structure.Decorator
{
    public class Boat : IDriveable
    {
        private IBoost boost;
        private IStop stop;

        public void Drive()
        {
            boost.Boost();
        }

        public void Stop()
        {
            stop.Stop();
        }

        public Boat()
        {
            boost = new BoatEngine();
            stop = new Anchor();
        }
    }
}
