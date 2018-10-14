using System;

namespace BasicAlgorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            // Factorial using recursion testing
            Console.WriteLine("Enter a number to calculate factorial: ");
            ulong lngFactorial = ulong.Parse(Console.ReadLine());
            Console.WriteLine($"The factorial value for {lngFactorial} is: {new Factorial().FactorialUsingRecursion(lngFactorial)}");
            Console.ReadLine();
        }
    }
}
