using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Behavioral.TemplateMethod
{
    public class Executor
    {
        public IStep1 step1;
        public IStep2 step2;
        public IStep3 step3;

        public Executor(IStep1 step1, IStep2 step2, IStep3 step3)
        {
            this.step1 = step1;
            this.step2 = step2;
            this.step3 = step3;
        }

        public string Execute(string param)
        {
            string s = step1.Execute(param);
            int i = step2.Execute(s);
            string s2 = step3.Execute(i);
            return s2;
        }
    }
}
