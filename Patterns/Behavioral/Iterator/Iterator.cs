using System;

namespace Patterns.Behavioral.Iterator
{
    public class Iterator: IPattern
    {
        public void Example()
        {
            var mat = new int[,] {{1, 2, 3}, {4, 5, 6}, {7, 8, 9}};

            var iter = new MatrixCustom<int>(mat);

            foreach (var i in iter)
            {
                var tmp = i;
                Console.WriteLine(i);
            }
        }
    }
}