using System;
using static System.Console;

namespace Exercise04
{
    class Program
    {
        static void Main(string[] args)
        {
            // try
            // {
            //     Write("Enter a number between 0 and 255: ");
            //     byte n1 = byte.Parse(ReadLine());
            //     Write("Enter another number between 0 and 255: ");
            //     byte n2 = byte.Parse(ReadLine());
            //     WriteLine(
            //         format: "{0} divided by {1} is {2}", 
            //         n1, 
            //         n2, 
            //         n1 / n2);
            // }
            // catch
            // {
            //     WriteLine("FormatException: Input string was not in a correct format.");
            // }

            int x;
            int y;

            x = 3;
            y = 2 + ++x;
            WriteLine($"x={x}, y={y}"); // x=4, y=6

            x = 3 << 2;
            y = 10 >> 1;
            WriteLine($"x={x}, y={y}"); // x=12, y=5

            x = 10 & 8;
            y = 10 | 7;
            WriteLine($"x={x}, y={y}"); // x=8, y=15

        }
    }
}
