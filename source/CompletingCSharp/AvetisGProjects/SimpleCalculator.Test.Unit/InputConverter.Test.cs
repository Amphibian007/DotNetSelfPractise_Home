using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using SampleCalculator;

namespace SimpleCalculator.Test.Unit
{
    [TestClass]
    public class InputConverter
    {
        private readonly InputConverter _inputConverter = new InputConverter();
        [TestMethod]
        public void ConvertStringToIntegerTest()
        {
            string inputNumber = "7";
        }
    }
}
