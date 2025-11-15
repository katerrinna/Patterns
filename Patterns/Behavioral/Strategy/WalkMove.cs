using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Behavioral.Strategy
{
    public class WalkMove : IMove
    {
        public string CreateRoute(string pointA, string pointB)
        {
            return "Путь из " + pointA + " в " + pointB + " пешком";
        }
    }
}
