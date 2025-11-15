using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Patterns.Behavioral.Visitor
{
    public class Visitor1 : IVisitor
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
