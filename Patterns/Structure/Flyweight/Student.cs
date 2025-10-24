using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Structure.Flyweight
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public StudentState State { get; set; }
    }
}
