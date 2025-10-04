using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Patterns.Generative.AbstractFactory;
using Patterns.Generative.Builder;
using Patterns.Generative.Factory_Method;
using Patterns.Generative.Prototype;
using Patterns.Generative.Singleton;
using Patterns.Structure.Adapter;
using Patterns.Structure.Bridge;

namespace Patterns
{
    internal class Program
    {
        private static List<IPattern> patterns = new List<IPattern>()
        {
            // new AbstractFactory(),
            // new FactoryMethod(),
            // new Builder(),
            // new Prototype(),
            // new Singleton()
            
            //new Adapter(),
            new Bridge()
        };
        
        static void Main(string[] args)
        {
            foreach (var pattern in patterns)
            {
                pattern.Example();
            }
        }

    }
}
