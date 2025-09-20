using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Generative.Singletone
{
    internal class DbConnection
    {
        static Connection Connection;

        public static Connection GetConnection()
        {
            if (Connection == null)
            {
                Connection = new Connection();  
            }
            return Connection;
        }
        

    }
}
