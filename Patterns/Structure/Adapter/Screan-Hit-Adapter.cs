using Patterns.Generative.AbstractFactory;

namespace Patterns.Structure.Adapter
{
    public class ScreamHitAdapter : IHit
    {
        private readonly IScream _scream;

        internal ScreamHitAdapter(IScream scream)
        {
            _scream = scream;
        }
        
        public void Hit()
        {
            _scream.Scream();
        }
    }
}