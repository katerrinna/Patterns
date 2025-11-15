using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Behavioral.TemplateMethod
{
    /// <summary>
    /// Этот паттерн предполагает под собой наличие метода, состоящего из вызовов методов классов, реализующих интерфейсы, передаваемые в объект класса
    /// </summary>
    public class TemplateMethod : IPattern
    {
        public void Example()
        {
            Executor executor = new Executor(new Step1(), new Step2(), new Step3());

            Console.WriteLine(executor.Execute("param"));
        }
    }
}
