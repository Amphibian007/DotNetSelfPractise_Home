using System;
using System.Numerics;

namespace InsideBook
{
    public class Program
    {
        static void Main(string[] args)
        {
            ////Prime number
            //int n = int.Parse(Console.ReadLine());
            //int divider = 2;
            //int highestDivider = (int)Math.Sqrt(n);
            //Console.WriteLine($"Highest number is {highestDivider}");
            //bool prime = true;
            //while (prime && (divider <= highestDivider))
            //{
            //    if (n % divider == 0)
            //    {
            //        prime = false;
            //    }
            //    divider++;
            //}
            //Console.WriteLine($"The result is {prime}");
            /////Factorial using For loop
            //int n = int.Parse(Console.ReadLine());
            //int factorial = 1;
            //for (int i = n; i > 1; i--)
            //{
            //    factorial *= i;
            //}
            //Console.WriteLine("Factorial is " + factorial);

            /////Factorial Using  while loop
            //int n = int.Parse(Console.ReadLine());
            //int factorial = 1;
            //while (true)
            //{
            //    if (n <= 1)
            //        break;
            //    factorial *= n;
            //    n--;
            //}
            //Console.WriteLine(factorial);

            ///
            //int n = int.Parse(Console.ReadLine());
            //BigInteger factorial = 1;
            //do
            //{
            //    factorial *= n;
            //    n--;
            //} while (n > 0);
            //Console.WriteLine(factorial);
            Console.WriteLine(CalculateInRange(1,10));
            
        }

        static public BigInteger CalculateInRange(int x,int y)
        {
            BigInteger result = 1;
            
            do
            {
                result *= x;
                x++;
            } while (x <= y);
            return result;
        }
       
    }
}
