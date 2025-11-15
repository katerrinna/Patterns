using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Behavioral.Visitor
{
    public interface IVisitor
    {
        void VisitElementA(ElementA elementA);
        void VisitElementB(ElementB elementB);
    }
}
