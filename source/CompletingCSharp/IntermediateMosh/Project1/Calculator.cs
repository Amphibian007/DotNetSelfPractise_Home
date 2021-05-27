using System;
using System.Collections.Generic;
using System.Text;

namespace Project1
{
    public class Calculator
    {
        public int Add(params int[] myArr)
        {
            int sum = 0;
            for(int i = 0; i < myArr.Length; i++)
            {
                sum += myArr[i];
            }
            return sum;
        }
    }
}
