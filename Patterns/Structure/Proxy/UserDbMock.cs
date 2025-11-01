using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace Patterns.Structure.Proxy
{
    public class UserDbMock
    {
        public List<User> Users = new List<User>()
        {
            new User(1, "Anton1"),
            new User(2, "Anton2"),
            new User(3, "Anton3")
        };

        public User GetUser(int id)
        {
            Thread.Sleep(100);
            return Users.FirstOrDefault(x => x.Id == id);
        }
    }
}