using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Behavioral.Strategy
{
    public interface IMove
    {
        string CreateRoute(string pointA, string pointB);
    }
}
