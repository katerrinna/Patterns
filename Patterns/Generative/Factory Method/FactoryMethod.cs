using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Generative.Factory_Method
{
    internal class FactoryMethod
    {
        public static void Example()
        {
            Car car1 = CarFactory.CreateToyota();
            Car car2 = CarFactory.CreateBMW();
            Console.WriteLine(car1 + " " + car2);
        }

    }
}
