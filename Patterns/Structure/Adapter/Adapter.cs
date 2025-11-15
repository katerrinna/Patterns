using System;
using Patterns.Generative.AbstractFactory;

namespace Patterns.Structure.Adapter
{
    /// <summary>
    /// Этот паттерн предполагает под собой наличие класса-переходника между методами с несовместимыми типами данных
    /// </summary>
    public class Adapter: IPattern
    {
        public void Example()
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