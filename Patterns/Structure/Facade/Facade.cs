using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Structure.Facade
{
    public class Facade : IPattern
    {
        public void Example()
        {
            StreamWriterFacade.Write("text", "newfile.txt");
        }
    }
}
