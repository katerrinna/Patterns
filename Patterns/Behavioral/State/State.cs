using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Behavioral.State
{
    /// <summary>
    /// Этот паттерн предполагает под собой изменение поведения объекта класса в зависимости от его состояния (поля State у класса Water)
    /// </summary>
    public class State : IPattern
    {
        public void Example()
        {
            Water water = new Water();
            water.WarmUp();
            water.WarmDown();
            water.WarmDown();
            water.WarmUp();
        }
    }
}
