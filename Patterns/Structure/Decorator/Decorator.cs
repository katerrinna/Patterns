using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Structure.Decorator
{
    /// <summary>
    /// Этот паттерн предполагает под собой наличие класса-обёртки (Boat) для 2 или более классов (BoatEngine и Anchor)
    /// </summary>
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
