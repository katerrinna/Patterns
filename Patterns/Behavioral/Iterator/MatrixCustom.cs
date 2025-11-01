using System.Collections;
using System.Collections.Generic;

namespace Patterns.Behavioral.Iterator
{
    public class MatrixCustom<T> : IEnumerable<T>
    {
        public T[,] Matrix;
        
        public MatrixCustom(T[,] matrix)
        {
            Matrix = matrix;
        }
        
        public IEnumerator<T> GetEnumerator()
        {
            return new  MatrixCustomIterator<T>(Matrix);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}