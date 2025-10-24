using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Structure.Flyweight
{
    public class StudentState
    {
        public string State { get; set; }

        public override bool Equals(object obj)
        {
            return State.Equals(((StudentState)obj).State);
        }
        public override int GetHashCode()
        {
            return State.GetHashCode();
        }
    }
}
