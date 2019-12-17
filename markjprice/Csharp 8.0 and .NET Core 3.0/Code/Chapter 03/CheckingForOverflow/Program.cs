using System;
using static System.Console;

namespace CheckingForOverflow
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = int.MaxValue - 1;
            unchecked
            {
                WriteLine($"Initial value: {i}.");
                i++;
                WriteLine($"After incrementing: {i}.");
                i++;
                WriteLine($"After incrementing: {i}.");
                i++;
                WriteLine($"After incrementing: {i}.");
                i = int.MaxValue + 1;
            }
            // catch (OverflowException)
            // {
            //     WriteLine("The code overflowed but I caught the exception.");
            // }
        }
    }
}