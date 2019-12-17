using System;
using static System.Console;

namespace Exercise31
{
    class Program
    {
        static void Main(string[] args)
        {
                        // // DivideByZeroException
            // int i = 1;
            // i = i / 0;
            // WriteLine($"i = {i}");
            
            // // d = ∞
            // double d = 10.10;
            // d = d / 0; 
            // WriteLine($"d = {d}");

            // // int variable set to a value beyond its range carries 1 to sign-bit
            // int i = int.MaxValue;
            // WriteLine($"i   = {Convert.ToString(i, 2)}");   // s111 1111 1111 1111 1111 1111 1111 1111
            // WriteLine($"++i = {Convert.ToString(++i, 2)}"); // 1000 0000 0000 0000 0000 0000 0000 0000

            // int max = 500;
            // WriteLine($"max = {max}");
            // for (byte i = 0; i < max; i++)
            // {
            //     WriteLine($"i = {i}");
            // }

            checked
            {
                try 
                {
                    int i = int.MaxValue;
                    short s = short.MaxValue;
                    long l = long.MaxValue;

                    WriteLine($"i = {i}");
                    WriteLine($"s = {s}");
                    WriteLine($"l = {l}\n\n");
                    // s = (short)l;
                    i++;
                    WriteLine($"i = {i}");
                    WriteLine($"s = {s}");
                    WriteLine($"l = {l}");
                }
                catch (OverflowException)
                {
                    WriteLine("oops OverflowException!");
                }
            }
        }
    }
}
