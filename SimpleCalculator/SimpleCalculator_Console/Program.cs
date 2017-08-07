using System;

namespace SimpleCalculator_Console
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            // Try, Catch, Finally
            try
            {
                // Exceptions
                string s_input = Console.ReadLine();
                try
                {
                    StringToIntConverter stringToIntConverter = new StringToIntConverter();
                    stringToIntConverter.convert(s_input);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("There was an error with conversion: {0}", ex.Message);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("There was an error: {0}", ex.Message);
            }
            finally /* frees up any unmanaged resources whether that catch ran or not */
            {
                Console.WriteLine("The rest of this application is still running.");
            }

            /* Keep the console window open til user applies input */
#if DEBUG
            Console.WriteLine("Press enter to close...");
            Console.ReadLine();
#endif
        }
    }
}