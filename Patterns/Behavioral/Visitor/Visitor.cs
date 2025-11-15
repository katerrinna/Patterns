using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Behavioral.Visitor
{
    /// <summary>
    /// Этот паттерн предполагает под собой такую структуру, что один или несколько объектов класса может обходить коллекцию других классов без изменения структуры последних
    /// </summary>
    public class Visitor : IPattern
    {
        public void Example()
        {
            ObjectStructure objectStructure = new ObjectStructure();
            ElementA elementA = new ElementA();
            ElementB elementB = new ElementB();
            objectStructure.AddElement(elementA);
            objectStructure.AddElement(elementB);

            Visitor1 visitor1 = new Visitor1();
            Visitor2 visitor2 = new Visitor2();

            objectStructure.Accept(visitor1);
            objectStructure.Accept(visitor2);
        }
    }
}
