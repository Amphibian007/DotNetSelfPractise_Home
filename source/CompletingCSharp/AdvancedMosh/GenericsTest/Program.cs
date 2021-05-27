using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsTest
{
    public class Program
    {
        static void Main(string[] args)
        {
            var n1 = new Nullable<double>(89);
            Console.WriteLine(n1.HasValue);
            Console.WriteLine(n1.GetValueOrDefault());
        }
    }
}
