using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethodPractise
{
    public class GenericsPractise
    {
        public bool IsEqual<T>(T num1,T num2) where T : IComparable<T>
        {
            return num1.CompareTo(num2)==0;
        }
    }
}
