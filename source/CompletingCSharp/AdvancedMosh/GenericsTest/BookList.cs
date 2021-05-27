using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsTest
{
    public class BookList<T>
    {
        public void Add(T vaule)
        {

        }
        public T this[int index]
        {
            get { throw new NotImplementedException(); }
        }
    }
}
