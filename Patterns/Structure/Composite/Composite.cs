using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Structure.Composite
{
    public class Composite : IPattern
    {
        public void Example()
        {
            LeafComposer leafComposer = new LeafComposer("root");
            for (int i = 0; i < 10; i++)
            {
                leafComposer.AddLeafToEnd(i.ToString());
            }
            Console.WriteLine(leafComposer.ToString());
        }
    }
}
