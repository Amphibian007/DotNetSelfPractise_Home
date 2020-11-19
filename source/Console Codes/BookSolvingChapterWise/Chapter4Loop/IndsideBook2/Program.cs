using System;
using System.Numerics;

namespace IndsideBook2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
           
            PrintPrime(n,m);
            //Draw(m);
            //Console.WriteLine(OddSum(m));
            //int n = int.Parse(Console.ReadLine());
            //TwoVariable(m,n);
            //Console.WriteLine(GetPower(m, n));
        }
        //static BigInteger GetPower(int m,int n)
        //{
        //    BigInteger result = 1 ;
        //    for(int i = 1; i <= n; i++)
        //    {
        //        result *= m;
        //    }
        //    return result;
        //}

        //static void TwoVariable(int small,int large)
        //{
        //    for (small=small, large = large; small < large; small++, large--)
        //    {
        //        Console.WriteLine($"{small} and {large}");
        //    }
        //}

        //static int OddSum(int n)
        //{
        //    int sum = 0;
        //    for(int i = 1; i <= n; i += 2)
        //    {
        //        if (i % 5 == 0)
        //            continue;
        //        sum += i;
        //    }
        //    return sum;
        //}

        //static void Draw(int m)
        //{
        //    for(int row = 1; row <= m; row++)
        //    {
        //        for(int col = 1; col <= row; col++)
        //        {
        //            Console.Write($"{col} ");
        //        }
        //        Console.WriteLine();
        //    }
        //}

        //static void CheckPrime(int m)
        //{
        //    int divisor = 2;
        //    bool prime = true;
        //    int highestDivisor = (int)Math.Sqrt(m);
        //    for(int i = divisor; i < highestDivisor; i++)
        //    {
        //        if (m % i == 0)
        //            prime = false;
              
        //    }
        //    Console.WriteLine(prime);
          
        //}

       
        static void PrintPrime(int n,int m)
        {
            int number, divider;
            for (number = n; number <= m; number++)
            {
                bool prime = true;
                int highestDivisor = (int)Math.Sqrt(number);
                for (divider = 2; divider <= highestDivisor; divider++)
                {
                    if (number % divider == 0)
                    {
                        prime = false;
                        break;
                    }

                }
                if (prime)
                {
                    Console.WriteLine($"{number} ");
                }
            }
        }
    }
}
