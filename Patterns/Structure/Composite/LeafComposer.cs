using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Structure.Composite
{
    public class LeafComposer
    {
        public Leaf Leaf { get; private set; }

        public LeafComposer(string firstLeafName)
        {
            Leaf = new Leaf() { Name = firstLeafName };
        }

        public void AddLeafToEnd(string name)
        {
            Leaf currentLeaf = Leaf;
            while (currentLeaf.NextLeaf != null)
            {
                currentLeaf = currentLeaf.NextLeaf;
            }
            currentLeaf.NextLeaf = new Leaf() { Name = name };
        }

        public override string ToString()
        {
            return Leaf.ToString();
        }
    }
}
