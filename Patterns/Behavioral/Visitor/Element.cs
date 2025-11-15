using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Behavioral.Visitor
{
    public abstract class Element
    {
        public abstract void Accept(IVisitor visitor);
    }

    public class ElementA : Element
    {
        public override void Accept(IVisitor visitor)
        {
            visitor.VisitElementA(this);
        }

        public void OperationA()
        {
            Console.WriteLine("Operation A");
        }
    }

    public class ElementB : Element
    {
        public override void Accept(IVisitor visitor)
        {
            visitor.VisitElementB(this);
        }

        public void OperationB()
        {
            Console.WriteLine("Operation B");
        }
    }
}
