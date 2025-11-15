using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Behavioral.State
{
    public class Water
    {
        public string State { get; private set; } = "Жидкость";
        public void WarmUp()
        {
            if (State == "Жидкость")
            {
                State = "Пар";
            }
            if (State == "Лёд")
            {
                State = "Жидкость";
            }
            Console.WriteLine("Я теперь " + State);
        }

        public void WarmDown() 
        {
            if (State == "Жидкость")
            {
                State = "Лёд";
            }
            if (State == "Пар")
            {
                State = "Жидкость";
            }
            Console.WriteLine("Я теперь " + State);
        }
    }
}
