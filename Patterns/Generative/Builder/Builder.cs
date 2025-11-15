using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Generative.Builder
{
    /// <summary>
    /// Этот паттерн предполагает под собой класс, инициализирующий другой класс вызовом цепочки методов в одну строку
    /// </summary>
    internal class Builder : IPattern
    {
        public void Example()
        {
            Car car = CarBuilder.Builder().Year(2015).ModelName("BMW").Build();
            Car car1 = CarBuilder.Builder().Year(1999).ModelName("Toyota").Build();
            Car car2 = CarBuilder.Builder().Year(2024).ModelName("Lada").Build();
            Console.WriteLine(car);
            Console.WriteLine(car1);
            Console.WriteLine(car2);
        }
    }
}
