using System;

namespace Patterns.Structure.Adapter
{
    public class BattleCry: IScream
    {
        public void Scream()
        {
            Console.WriteLine("Arrrrrrrrrrr!!!!");
        }
    }
}