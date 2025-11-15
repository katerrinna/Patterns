using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Generative.Factory_Method
{
    /// <summary>
    /// Этот паттерн предполагает под собой класс, инициализирующий объекты других классов, при этом для каждого типа объектов существует отдельный метод
    /// </summary>
    internal class FactoryMethod: IPattern
    {
        public void Example()
        {
            Car car1 = CarFactory.CreateToyota();
            Car car2 = CarFactory.CreateBMW();
            Console.WriteLine(car1 + " " + car2);
        }

    }
}
