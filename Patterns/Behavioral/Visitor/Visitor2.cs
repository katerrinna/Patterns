using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Behavioral.Visitor
{
    public class Visitor2 : IVisitor
    {
        public void VisitElementA(ElementA elementA)
        {
            elementA.OperationA();
        }

        public void VisitElementB(ElementB elementB)
        {
            elementB.OperationB();
        }
    }
}
