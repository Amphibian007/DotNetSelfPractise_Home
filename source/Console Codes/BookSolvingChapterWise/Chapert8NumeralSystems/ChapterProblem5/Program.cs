using System;
using System.Collections.Generic;

namespace ChapterProblem5
{
    class Program
    {
        static void Main(string[] args)
        {
            double sum = 0;
            int digit ;
            int j = 0;
            int number = int.Parse(Console.ReadLine());
            while (number > 0)
            {
                digit = number % 10;               
                sum += digit * Math.Pow(2, j);
                j++;               
                number /= 10;
            }
            Console.WriteLine(sum);
        }
    }
}
