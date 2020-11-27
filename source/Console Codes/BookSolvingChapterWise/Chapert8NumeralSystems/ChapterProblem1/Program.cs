using System;
using System.Collections.Generic;

namespace ChapterProblem1
{
    class Program
    {
        static void Main(string[] args)
        {
            int result, remainder;
            List<int> myInput = new List<int>();
            int input = int.Parse(Console.ReadLine());
            for(int i = 0; i < 100; i++,input/=2)
            {
                result = input / 2;
                remainder = input - (result * 2);
                myInput.Add(remainder);   
                if (result == 1)
                    break;          
            }
            myInput.Reverse();
            Console.Write(1);
            foreach (var item in myInput)
                Console.Write(item);
        }
    }
}
