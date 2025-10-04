using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Patterns.Structure.Adapter;

namespace Patterns.Generative.AbstractFactory
{
    internal class HeroFactory
    {
        public static Hero CreateAbstractHero(IHit hit, IMovement movement) {
            Hero hero = new Hero();
            hero.hit = hit;
            hero.movement = movement;
            return hero;
        }

        public static Hero createWarior() {
            return CreateAbstractHero(new SwordSwing(), new Boost());
        }

        public static Hero createRanger()
        {
            return CreateAbstractHero(new BowShoot(), new GoOn());
        }
        
        public static Hero createScreamer()
        {
            return CreateAbstractHero(new ScreamHitAdapter(new BattleCry()), new GoOn());
        }
    }
}
