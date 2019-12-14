using System;
using static System.Console;

namespace BitwiseAndShiftOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10; // 0000 1010
            int b =  6; // 0000 0110
            WriteLine($"a = {a}");
            WriteLine($"b = {b}");
            WriteLine($"a & b = {a & b}"); // 0000 0010
            WriteLine($"a | b = {a | b}"); // 0000 1110
            WriteLine($"a ^ b = {a ^ b}"); // 0000 1100
            WriteLine();
            // 0101 0000 left-shift a by three bit columns
            WriteLine($"a={a}");
            WriteLine($"a << 3 = {a << 3}");
            WriteLine($"a={a}");
            // bultiply a by 8
            WriteLine($"a * 8 = {a * 8}");
            // 0000 0011 right-shift b by one bit column
            WriteLine($"b >> 1 = {b >> 1}");
         }
    }
}
