using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Generative.Prototype
{
    internal class Prototype
    {
        public static void Example()
        { 
            CarPrototype car1 = new CarPrototype();
            car1.Year = 2013;
            car1.ModelName = "Toyota";

            CarPrototype car2 = CarPrototype.Clone(car1);
            Console.Write(car1);
            Console.Write(car2);
        }
 
    }
}
