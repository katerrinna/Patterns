using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Generative.Factory_Method
{
    internal class CarFactory
    {
        public static Car CreateToyota()
        {
            Car car = new Car();
            car.ModelName = "Toyota";
            return car;
        }
        public static Car CreateBMW()
        {
            Car car = new Car();
            car.ModelName = "BMW";
            return car;
        }
    }
}
