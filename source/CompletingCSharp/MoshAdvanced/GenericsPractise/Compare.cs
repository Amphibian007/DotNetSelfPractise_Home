using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsPractise
{
    public class Compare<T> where T : IComparable
    {
        public T Highest(T a, T b)
        {
            return a.CompareTo(b) > 0 ? a : b;
        }
    }
}
