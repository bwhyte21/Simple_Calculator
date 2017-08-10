using System;

namespace SimpleCalculator_Console
{
    public class InputConverter
    {
        public double ConvertInputToNumeric(string s_argTextInput)
        {
            double d_convertedNo;
            if (!double.TryParse(s_argTextInput, out d_convertedNo))
            {
                throw new ArgumentException("Expected a numeric value.");
            }
            return d_convertedNo;
        }
    }
}