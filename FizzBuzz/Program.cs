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
                if (counter % 11 == 0)
                {
                    if (counter % 13 == 0)
                    {
                        Console.WriteLine("FezzBong");
                    }
                    else
                    {
                        Console.WriteLine("Bong");
                    }
                    continue;
                }
                
                var parts = new List<string>();
                
                if (counter % 3 == 0)
                {
                    parts.Add("Fizz");
                }
                if (counter % 13 == 0)
                {
                    parts.Add("Fezz");
                }
                if (counter % 5 == 0)
                {
                    parts.Add("Buzz");
                }
                if (counter % 7 == 0)
                {
                    parts.Add("Bang");
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