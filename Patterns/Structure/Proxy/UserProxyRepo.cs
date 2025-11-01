using System.Collections.Generic;
using System.Linq;

namespace Patterns.Structure.Proxy
{
    public class UserProxyRepo
    {
        private List<User> Users = new List<User>();
        private UserDbMock db = new UserDbMock();

        public User GetUser(int id)
        {
            var user = db.Users.FirstOrDefault(x => x.Id == id);
            if (user == null)
            {
                user = db.GetUser(id);
                if (user != null)
                {
                    Users.Add(user);
                }
            }

            return user;
        }
    }
}