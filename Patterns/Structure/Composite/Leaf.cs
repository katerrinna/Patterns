using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Structure.Composite
{
    public class Leaf
    {
        public string Name { get; set; }
        public Leaf NextLeaf { get; set; }

        public override string ToString()
        {
            string result = "Leaf " + Name + " ";
            if (NextLeaf != null) 
            {
                result += NextLeaf.ToString();
            }
            return result;
        }
    }
}
