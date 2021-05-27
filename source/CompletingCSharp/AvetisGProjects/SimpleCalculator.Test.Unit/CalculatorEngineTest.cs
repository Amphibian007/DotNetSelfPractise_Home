using Microsoft.VisualStudio.TestTools.UnitTesting;
using SampleCalculator;
using System;

namespace SimpleCalculator.Test.Unit
{
    [TestClass]
    public class CalculatorEngineTest
    {
        private readonly CalculateEngine _calculateEngine = new CalculateEngine();
        [TestMethod]
        public  void AddTwoNumbersAndReturnResultForNonSymbolOperation ()
        {
            int number1 = 2;
            int number2 = 1;
            double result = _calculateEngine.Calculate("add", number1, number2);
            Assert.AreEqual(3, result);
        }
        [TestMethod]
        public void AddTwoNumbersAndReturnResultForSymbolOperation()
        {
            int number1 = 2;
            int number2 = 1;
            double result = _calculateEngine.Calculate("+", number1, number2);
            Assert.AreEqual(3, result);
        }
    }
}
