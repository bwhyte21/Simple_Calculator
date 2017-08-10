using System;

namespace SimpleCalculator_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                InputConverter ic_inputConverter = new InputConverter();
                CalculatorEngine ce_calculatorEngine = new CalculatorEngine();

                double d_firstNo = ic_inputConverter.ConvertInputToNumeric(Console.ReadLine());
                double d_secondNo = ic_inputConverter.ConvertInputToNumeric(Console.ReadLine());
                string s_operation = Console.ReadLine();

                double d_result = ce_calculatorEngine.Calculate(s_operation, d_firstNo, d_secondNo);

                Console.WriteLine(d_result);
            }
            catch (Exception ex)
            {
                // In the real world, we'd want to log this message
                Console.WriteLine(ex.Message);
            }

            /* Keep the console window open til user applies input */
#if DEBUG
            Console.WriteLine("Press enter to close...");
            Console.ReadLine();
#endif
        }
    }
}