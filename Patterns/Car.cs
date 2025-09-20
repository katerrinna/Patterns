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
        { string result = "Car ";

            if (ModelName != null )
            {
                result  = result + "Model: " + ModelName + " " ;
            }
            if (Year != 0)
            {
                result = result + "Year: " + Year + " ";
            }
            return result;
        }
    }
}
