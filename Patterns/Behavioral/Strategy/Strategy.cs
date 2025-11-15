using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Behavioral.Strategy
{
    /// <summary>
    /// Этот паттерн предполагает под собой наличие класса (Navigator), который в зависимости от входящего параметра выбирает, по какой стратегии ему действовать (выбор между классами WalkMove и CarMove)
    /// </summary>
    public class Strategy : IPattern
    {
        public void Example()
        {
            Navigator navigator = new Navigator();
            navigator.MakeRoute("A", "B", "Пешком");
            navigator.MakeRoute("C", "D", "На машине");
        }
    }
}
