using System;
using System.Collections.Generic;
using System.Text;

namespace DelegatePractise
{
    public delegate void DivDelegate(int x, int y);
    public delegate void HelloDelegate(string name);
    public class PractiseDelegatePart2
    {
        
        public void SayHello(string myName)
        {
            Console.WriteLine($"Hello {myName}");
        }
        public void SayHelloGorgeously(string myName)
        {
            Console.WriteLine($"Hello {myName} gorgeously");
        }
    }
}
