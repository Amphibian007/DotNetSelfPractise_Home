using System;

namespace InsideBook4
{
    class Program
    {
        static void Main(string[] args)
        {
            Sum(10);
           
        }
        //static bool CheckPrime(int m)
        //{
        //    bool prime = true;
        //    int highestDivisor = (int)Math.Sqrt(m);
        //    for(int divisor = 2; divisor <= highestDivisor; divisor++)
        //    {
        //        if (m % divisor == 0)
        //        {
        //            prime = false;
        //        }               
        //    }
        //    if (true)
        //        return prime;
        //}
        //static void PrintPrime(int n, int m)
        //{
        //    int number, divider;
        //    for (number = n; number <= m; number++)
        //    {
        //        bool prime = true;
        //        int highestdivider = (int)Math.Sqrt(number);
        //        for (divider = 2; divider <= highestdivider; divider++)
        //        {
        //            if (number % divider == 0)
        //                prime = false;
        //        }
        //        if(prime)
        //            Console.WriteLine($"{number} ");
        //    }
        //}

        //static int Factorial(int m)
        //{
        //    int result = 1;
        //    for(int i = m; i >= 1; i--)
        //    {
        //        result *= i;
        //    }
        //    return result;
        //}

        static void Sum(int m)
        {
            int sum = 0;
            for(int i = 1; i <= m; i+=2)
            {
                //if (i % 7 == 0)
                //    continue;
                sum += i;
            }
            Console.WriteLine(sum);
        }
    }
}
