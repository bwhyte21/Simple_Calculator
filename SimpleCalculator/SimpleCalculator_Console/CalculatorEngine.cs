using System;

namespace SimpleCalculator_Console
{
    public class CalculatorEngine
    {
        public double Calculate(string s_argOperation, double d_argFirstNo, double d_argSecondNo)
        {
            double d_result;

            switch (s_argOperation.ToLower())
            {
                case "add":
                case "+":
                    d_result = d_argFirstNo + d_argSecondNo;
                    break;
                case "subtract":
                case "-":
                    d_result = d_argFirstNo - d_argSecondNo;
                    break;
                case "multiply":
                case "*":
                    d_result = d_argFirstNo * d_argSecondNo;
                    break;
                case "divide":
                case "/":
                    d_result = d_argFirstNo / d_argSecondNo;
                    break;
                default:
                    throw new InvalidOperationException("Specified operation is not recognized");
            }

            return d_result;
        }
    }
}