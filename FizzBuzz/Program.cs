using System;

namespace FizzBuzz
{
    class Program
    {
        public static void Main(string[] args)
        {
            //Your code goes here
            Console.WriteLine("Hello, world!");
            for (int i = 1; i <= 100; i++)
            {
                var x = i % 1;

                var print = (i % 3 == 0 || i % 5 == 0) ? (i % 3 == 0 && i % 5 == 0) ? "\t\tFizzBuz" : (i % 3 == 0) ? "\tFizz" : "\tBuzz" : i.ToString();
                Console.WriteLine("\t\t" + print);
                Console.WriteLine("\n\r");
            }
        }
    }
}
