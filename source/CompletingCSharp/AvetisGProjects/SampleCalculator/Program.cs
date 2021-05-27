using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                try
                {
                    InputConverter inputConverter = new InputConverter();
                    CalculateEngine calculateEngine = new CalculateEngine();

                    Console.WriteLine("Enter the first number");
                    double firstNumber = inputConverter.InputToNumeric(Console.ReadLine());
                    Console.WriteLine("Enter the second number");
                    double secondNumber = inputConverter.InputToNumeric(Console.ReadLine());
                    Console.WriteLine("Enter the operation");
                    string operation = Console.ReadLine().ToLower();
                    double result = calculateEngine.Calculate(operation, firstNumber, secondNumber);
                    Console.WriteLine(result);

                }
                catch (Exception ex)
                {

                    Console.WriteLine(ex.Message);
                }
                Console.WriteLine("Do you want to continue? y/n");
                var opinion = Console.ReadLine();
                if (opinion == "n")
                    break;

            }

        }
    }
}
