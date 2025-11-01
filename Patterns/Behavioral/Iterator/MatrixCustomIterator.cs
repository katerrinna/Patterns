using System;
using System.Collections;
using System.Collections.Generic;

namespace Patterns.Behavioral.Iterator
{
    public class MatrixCustomIterator<T> : IEnumerator<T>
    {
        public T[,] Matrix;
        private int currentIndex = -1;

        public MatrixCustomIterator(T[,] matrix)
        {
            Matrix = matrix;
        }

        public bool MoveNext()
        {
            if (currentIndex >= Matrix.Length - 1) return false;

            currentIndex++;
            return true;
        }

        public void Reset()
        {
            currentIndex = 0;
        }

        public T Current
        {
            get
            {
                var x = currentIndex % Matrix.GetLength(0);
                var y = currentIndex / Matrix.GetLength(1);
                return Matrix[y, x];
            }
        }

        object IEnumerator.Current => Current;


        public void Dispose()
        {
        }
    }
}