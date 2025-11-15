using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Generative.Singleton
{
    /// <summary>
    /// Этот паттерн предполагает под собой класс, у которого возможен только 1 созданный объект в памяти приложения
    /// </summary>
    public class Singleton: IPattern
    {
        public void Example() {

            Connection connection1 = DbConnection.GetConnection();
            Connection connection2 = DbConnection.GetConnection();
            Console.WriteLine("Both connection are equals?");
            Console.WriteLine(connection1.Equals(connection2));
        }
    }
}
