using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            string s_someText = "Here is some text";
            int i_number = 10;
            double d_number = 10.5;
            float f_number = 10.6f;
            bool b_isOrdered = true;
            string s_input = Console.ReadLine();
            var v_anyVariable = 10.7;

            Console.WriteLine(s_someText);
            Console.WriteLine(i_number);
            Console.WriteLine(d_number);
            Console.WriteLine(f_number);
            Console.WriteLine(b_isOrdered);
            Console.WriteLine(s_input);
            Console.WriteLine(v_anyVariable);

            return;
            // ToDo: Clear this and continue from Section 2 Lecture 9
        }
    }
}
