using System;
using System.Collections.Generic;
using System.Text;

namespace Project1
{
    public class IndexerPractise<T>
    {
        private T[] store=new T[10];
        public T this[int index]
        {
            get
            {
                if (index < 0 || index >= store.Length)
                    throw new IndexOutOfRangeException("Index is out of range");
                return store[index];
            }
            set
            {
                if (index < 0 || index >= store.Length)
                    throw new IndexOutOfRangeException("Index is out of range");
                store[index] = value;
            }
        }
       
    }
}
