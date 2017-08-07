using System;

namespace SimpleCalculator_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            string s_someText = "Here is Some text";
            string s_someMoreText = "Here is some text";

            // using ordinal case for string comparison is faster
            bool b_isEqual = s_someText.Equals(s_someMoreText, StringComparison.Ordinal);

            string s_addedText = s_someText + " " + s_someMoreText + " here is some more text.";
            string s_formattedString = string.Format("{0} {1} here is some more text.", s_someText, s_someMoreText);

            Console.WriteLine(s_addedText);
            Console.WriteLine(s_formattedString);

            Console.WriteLine(s_someText.Length);
            Console.WriteLine(s_someText[8]);

            Console.WriteLine(s_someText.Substring(8, 4));

            Console.WriteLine(s_someText.ToLower());
            Console.WriteLine(s_someText.ToUpper());

            string s_anotherText = string.Empty;
            string s_replacedText = s_someText.Replace("text", "string");

            Console.WriteLine(s_replacedText);


            /* Keep the console window open til user applies input */
            #if DEBUG
            Console.WriteLine("Press enter to close...");
            Console.ReadLine();
            #endif
        }
    }
}