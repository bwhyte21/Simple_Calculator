using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SimpleCalculator_Console.Test.Unit
{
    [TestClass]
    public class InputConverterTest
    {
        private readonly InputConverter ic_inputConverter = new InputConverter();
        [TestMethod]
        public void ConvertValidStringInputIntoDouble()
        {
            string s_inputNo = "5";
            double d_convertedNo = ic_inputConverter.ConvertInputToNumeric(s_inputNo);
            Assert.AreEqual(5, d_convertedNo);
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void FailsToConvertInvalidStringInputIntoDouble()
        {
            string s_inputNo = "*";
            double d_convertedNo = ic_inputConverter.ConvertInputToNumeric(s_inputNo);
            Assert.AreEqual(5, d_convertedNo);
        }
    }
}
