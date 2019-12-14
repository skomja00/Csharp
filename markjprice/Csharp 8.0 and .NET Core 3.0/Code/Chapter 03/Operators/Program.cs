﻿using System;
using static System.Console;

namespace Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            // postfix operator
            int a = 3;
            int b = a++;
            WriteLine($"a is {a}, b is {b}");

            // prefix operator
            int c = 3;
            int d = ++c;
            WriteLine($"a is {c}, b is {d}");

            int e = 11;
            int f = 3;
            WriteLine($"e is {e}. f is {f}");
            WriteLine($"e + f = {e + f}");
            WriteLine($"e - f = {e - f}");
            WriteLine($"e * f = {e * f}");
            WriteLine($"e / f = {e / f}");
            WriteLine($"e % f = {e % f}");

            double g = 11.0;
            WriteLine($"g is {g:N1}, f is {f}");
            WriteLine($"g / f = {g / f}");

            int p = 6;
            WriteLine($"p is {p}");//p += 3; // equivalent to p = p + 3;
            WriteLine($"p+= 3; is {p += 3}");//p += 3; // equivalent to p = p + 3;
            // p -= 3; // equivalent to p = p - 3;
            WriteLine($"p-= 3; is {p -= 3}");//p += 3; // equivalent to p = p - 3;
            // p *= 3; // equivalent to p = p * 3;
            WriteLine($"p*= 3; is {p *= 3}");//p += 3; // equivalent to p = p * 3;
            // p /= 3; // equivalent to p = p / 3;
            WriteLine($"p/= 3; is {p /= 3}");//p += 3; // equivalent to p = p / 3;

        }
    }
}