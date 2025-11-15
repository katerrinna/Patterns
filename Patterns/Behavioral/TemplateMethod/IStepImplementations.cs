using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Behavioral.TemplateMethod
{
    public class Step1 : IStep1
    {
        public string Execute(string param)
        {
            return param + param;
        }
    }

    public class Step2 : IStep2
    {
        public int Execute(string param)
        {
            return param.Length;
        }
    }

    public class Step3 : IStep3
    {
        public string Execute(int param)
        {
            return param.ToString();
        }
    }
}
