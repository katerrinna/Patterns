using System;
using Patterns.Generative.AbstractFactory;

namespace Patterns.Structure.Adapter
{
    public class Adapter
    {
        public static void Example()
        {
            Hero a = HeroFactory.createWarior();
            Hero b = HeroFactory.createScreamer();
            
            a.Hit();
            a.Move();

            Console.WriteLine("----------");
            
            b.Hit();
            b.Move();
        }
    }
}