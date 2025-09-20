using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Generative.AbstractFactory
{
    internal class Hero
    {
        public IHit hit { get; set; }
        public IMovement movement { get; set; }
        public void Hit()
        {
            hit.Hit();
            
        }
        public void Move()
        {
            movement.Move();
        }
    }
}
