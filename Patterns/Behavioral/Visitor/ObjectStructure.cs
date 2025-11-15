using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Behavioral.Visitor
{
    public class ObjectStructure
    {
        public List<Element> elements = new List<Element>();

        public void AddElement(Element element)
        {
            elements.Add(element);
        }

        public void RemoveElement(Element element)
        {
            elements.Remove(element);
        }

        public void Accept(IVisitor visitor)
        {
            foreach (Element element in elements)
            {
                element.Accept(visitor);
            }
        }
    }
}
