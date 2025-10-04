using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Patterns.Generative.AbstractFactory;
using Patterns.Generative.Builder;
using Patterns.Generative.Factory_Method;
using Patterns.Generative.Prototype;
using Patterns.Generative.Singletone;
using Patterns.Structure.Adapter;

namespace Patterns
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //  Singletone.Example();
            //FactoryMethod.Example();
            //Builder.Example();
            //Prototype.Example();
            // AbstractFactory.Example();
            
            Adapter.Example();
        }

    }
}
