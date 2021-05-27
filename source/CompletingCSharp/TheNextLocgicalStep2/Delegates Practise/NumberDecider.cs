using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates_Practise
{
  
    public class NumberDecider
    {
        public bool DivByThree(int num)
        {
            return num % 3 == 0;
        }
        public bool DivByFive(int num)
        {
            return num % 5 == 0;
        }
        public bool DivByNine(int num)
        {
            return num % 9 == 0;
        }

        public List<int> NumberDivisor(int[] numbers,Func<int,bool> filter)
        {
            List<int> myNumbers = new List<int>();
            foreach(var number in numbers)
            {
                if (filter(number))
                {
                    myNumbers.Add(number);
                }
            }
            return myNumbers;
        }
    }
  
}
