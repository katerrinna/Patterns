using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns
{
    internal class Car
    {
        public string ModelName { get; set; }
        public int Year { get; set; }
        public override string ToString()
        {
            return "Car Model: " + ModelName;
        }
    }
}
