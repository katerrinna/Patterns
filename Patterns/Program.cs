using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Patterns.Behavioral.ChainOfResponsibility;
using Patterns.Behavioral.Command;
using Patterns.Behavioral.Iterator;
using Patterns.Behavioral.Mediator;
using Patterns.Generative.AbstractFactory;
using Patterns.Generative.Builder;
using Patterns.Generative.Factory_Method;
using Patterns.Generative.Prototype;
using Patterns.Generative.Singleton;
using Patterns.Structure.Adapter;
using Patterns.Structure.Bridge;
using Patterns.Structure.Composite;
using Patterns.Structure.Decorator;
using Patterns.Structure.Facade;
using Patterns.Structure.Flyweight;
using Patterns.Structure.Proxy;

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
            //new Bridge(),
            //new Composite(),
            //new Decorator(),
            //new Facade(),
            // new Flyweight(),
            // new Proxy(),
            // new ChainOfResponsibility(),
            // new Command(),
            // new Iterator(),
            new Mediator()
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
