using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator_Console
{
    class StringToIntConverter
    {
        public int convert(string s_input)
        {
            try
            {
                int n_convertedNumber;
                bool b_isConverted = int.TryParse(s_input, out n_convertedNumber);

                if (!b_isConverted)
                {
                    throw new Exception("Conversion failed...");
                }
                return n_convertedNumber;
            }
            catch (Exception ex)
            {

                throw new Exception("new message", ex); //throw exception up to caller
            }
        }
    }
}
