using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Behavioral.Strategy
{
    public class Navigator
    {
        public Navigator() { }

        public void MakeRoute(string start, string finish, string wayToMove)
        {
            if (wayToMove == "Пешком")
            {
                //логика для хождения пешком
                Console.WriteLine(new WalkMove().CreateRoute(start, finish));
            }
            if (wayToMove == "На машине")
            {
                //логика для езды на машине
                Console.WriteLine(new CarMove().CreateRoute(start, finish));
            }
        }
    }
}
