using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SimpleCalculator_Console.Test.Unit
{
    [TestClass]
    public class CalculatorEngineTest
    {
        private readonly CalculatorEngine ce_calculatorEngine = new CalculatorEngine();

        [TestMethod]
        public void AddsTwoNumbersAndReturnsValidResultForNonSymbolOperation()
        {
            int n_number1 = 1;
            int n_number2 = 2;
            double d_result = ce_calculatorEngine.Calculate("add", n_number1, n_number2);
            // Assert is another way to check if the result matches the outcome it's meant to be
            Assert.AreEqual(3, d_result);
        }

        [TestMethod]
        public void AddsTwoNumbersAndReturnsValidResultForSymbolOperation()
        {
            int n_number1 = 1;
            int n_number2 = 2;
            double d_result = ce_calculatorEngine.Calculate("+", n_number1, n_number2);
            Assert.AreEqual(3, d_result);
        }
    }
}
