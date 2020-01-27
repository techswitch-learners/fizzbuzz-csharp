using System;
using System.Collections.Generic;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            for (var counter = 1; counter <= 500; counter++)
            {
                var parts = GetParts(counter);

                if (counter % 17 == 0)
                {
                    parts.Reverse();
                }

                if (parts.Count == 0)
                {
                    Console.WriteLine(counter);
                }
                else
                {
                    Console.WriteLine(string.Join("", parts));
                }
            }
        }

        static List<string> GetParts(int number)
        {
            var parts = new List<string>();
            
            if (number % 11 == 0)
            {
                if (number % 13 == 0)
                {
                    parts.Add("Fezz");
                }
                parts.Add("Bong");

                return parts;
            }
            
            if (number % 3 == 0)
            {
                parts.Add("Fizz");
            }
            if (number % 13 == 0)
            {
                parts.Add("Fezz");
            }
            if (number % 5 == 0)
            {
                parts.Add("Buzz");
            }
            if (number % 7 == 0)
            {
                parts.Add("Bang");
            }

            return parts;
        }
    }
}