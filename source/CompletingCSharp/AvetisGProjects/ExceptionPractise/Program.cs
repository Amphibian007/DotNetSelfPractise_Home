using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionPractise
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string input = Console.ReadLine();
                int convertedNumber;
                bool isConvertedSuccessfully = int.TryParse(input, out convertedNumber);
                Console.WriteLine(convertedNumber);
                if (!isConvertedSuccessfully)
                {
                    throw new Exception("Input is not successfully converted to number");
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine($"Error message is {ex.Message}");
            }
        }
    }
}
