using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Generative.Builder
{
    internal class CarBuilder
    {
        private Car car;

        private CarBuilder(Car car)
        {
            this.car = car;
        }

        public static CarBuilder Builder()
        {
            Car car = new Car();
            return new CarBuilder(car);
        }

        public CarBuilder ModelName(string modelName) { 
            this.car.ModelName = modelName;
            return this;
        }

        public CarBuilder Year(int year)
        {
            this.car.Year = year;
            return this;
        }

        public Car Build() {
            return this.car;
        }
    }
}
