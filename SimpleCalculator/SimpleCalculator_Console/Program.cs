using System;

namespace SimpleCalculator_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            // Exceptions
            string s_input = Console.ReadLine();
            int n_convertedNumber;
            bool b_isConverted = int.TryParse(s_input, out n_convertedNumber);

            if (!b_isConverted)
            {
                throw new Exception("Conversion failed...");
            }

            /* Keep the console window open til user applies input */
#if DEBUG
            Console.WriteLine("Press enter to close...");
            Console.ReadLine();
            #endif
        }
    }
}