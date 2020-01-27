using System;
using System.Collections.Generic;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            for (var counter = 1; counter <= 100; counter++)
            {
                var parts = new List<string>();
                
                if (counter % 3 == 0)
                {
                    parts.Add("Fizz");
                } 
                if (counter % 5 == 0)
                {
                    parts.Add("Buzz");
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
    }
}