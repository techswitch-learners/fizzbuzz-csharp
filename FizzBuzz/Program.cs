using System;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            for (var counter = 1; counter <= 100; counter++)
            {
                if (counter % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else
                {
                    Console.WriteLine(counter);
                }
            }
        }
    }
}