using System;

namespace Patterns.Structure.Proxy
{
    public class Proxy: IPattern
    {
        private UserDbMock db = new UserDbMock();
        private UserProxyRepo repo = new UserProxyRepo();
        
        public void Example()
        {
            var t1 = DateTime.Now;
            
            for (int i = 0; i < 100; i++)
            {
                db.GetUser((i % 3) + 1);
            }
            
            var t2 = DateTime.Now;
            
            Console.WriteLine($"Work with db finished  {t2 - t1}" );
            
            
            t1 = DateTime.Now;
            for (int i = 0; i < 100; i++)
            {
                repo.GetUser((i % 3) + 1);
            }
            
            t2 = DateTime.Now;
            Console.WriteLine($"Work with repo finished  {t2 - t1}" );
        }
    }
}