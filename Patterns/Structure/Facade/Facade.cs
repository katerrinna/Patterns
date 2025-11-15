using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Structure.Facade
{
    /// <summary>
    /// Этот паттерн предполагает под собой наличие простого в использовании класса, который содержит внутри себя сложную логику 
    /// </summary>
    public class Facade : IPattern
    {
        public void Example()
        {
            StreamWriterFacade.Write("text", "newfile.txt");
        }
    }
}
