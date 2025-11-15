using System;

namespace Patterns.Structure.Bridge
{
    /// <summary>
    /// Этот паттерн предполагает под собой совмещение разных классификаций в одном классе
    /// </summary>
    public class Bridge: IPattern
    {
        public void Example()
        {
            var a = new Circle(new Blue());
            var b = new Star(new Red());
            var c = new Rectangle(new Green());
            
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
        }
    }
}