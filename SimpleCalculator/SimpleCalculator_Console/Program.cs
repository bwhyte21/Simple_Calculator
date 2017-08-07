using System;

namespace SimpleCalculator_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            // non static
            Person person1 = new Person();

            Console.WriteLine(person1.getAge());
            person1.setAge(27);
            Console.WriteLine(person1.getAge());

            // static
            Person.greet();

            /* Keep the console window open til user applies input */
#if DEBUG
            Console.WriteLine("Press enter to close...");
            Console.ReadLine();
            #endif
        }
    }
}