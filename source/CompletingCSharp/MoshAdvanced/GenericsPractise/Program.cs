using System;

namespace GenericsPractise
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = new Nullable<double>(8);
            Console.WriteLine("Has value?"+number.HasValue);
            Console.WriteLine("Original value is "+number.GetValueOrDefault());
        }
        public class GenericList<T>
        {
            public void Add(T value)
            {

            }
            public T this[int index]
            {
                get {throw new NotImplementedException(); }
            }
        }
        public class GenericDictionary<TKey, TValue>
        {
            public void Add(TKey number,TValue value)
            {

            }
        }

    }
}
