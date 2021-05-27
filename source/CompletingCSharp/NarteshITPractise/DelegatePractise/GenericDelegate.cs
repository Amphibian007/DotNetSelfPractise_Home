using System;
using System.Collections.Generic;
using System.Text;

namespace DelegatePractise
{
    //public delegate double Delegate1(int x, float y, double z);
    //public delegate void Delegate2(int x, float y, double z);
    //public delegate bool Delegate3(int x);
    public class GenericDelegate
    {
        public double AddNumbers1(int x,float y,double z)
        {
            return x + y + z;
        }
        public void AddNumbers2(int x,float y, double z)
        {
            Console.WriteLine($"The sum is {(x+y+z)}");
        }
        public bool IsEven(int x)
        {
            if (x % 2 == 0)
                return true;
            else
                return false;
        }
    }
}
