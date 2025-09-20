using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Generative.Prototype
{
    internal class CarPrototype:Car
    {
        public static CarPrototype Clone(Car car)
        {
            CarPrototype newCar = new CarPrototype();
            newCar.Year = car.Year;
            newCar.ModelName = car.ModelName;
            return newCar;
        }
    }
}
