using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleCalculator
{
    public class CalculateEngine
    {
        public double Calculate(string operation, double firstNumber, double secondNumber)
        {
            double result;
            switch (operation)
            {
                case "add":
                case "+":
                    result = firstNumber + secondNumber;
                    break;
                case "subtract":
                case "-":
                    result = firstNumber - secondNumber;
                    break;
                case "multiplication":
                case "*":
                    result = firstNumber * secondNumber;
                    break;
                case "division":
                case "/":
                    {
                        if (secondNumber == 0)
                        {
                            throw new Exception("Can't divide by zero");
                        }
                        result = firstNumber / secondNumber;
                    }
                    break;
                default:
                    throw new InvalidOperationException("Operation is not valid");
            }
            return result;
        }
    }
}
