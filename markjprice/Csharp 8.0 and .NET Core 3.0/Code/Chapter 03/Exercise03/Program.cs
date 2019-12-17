using System;
using static System.Console;

namespace Exercise03
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "";
            int max = 100;
            for (int i = 1; i <= max; i++)
            {
                if (i % 3 == 0) 
                {
                    s = "Fizz";
                }
                if (i % 5 == 0) 
                {
                    s += "Buzz";
                }
                if (s == "") 
                {
                    s = i.ToString();
                }
                if (i == max)
                {
                    Write($"{s}");
                }
                else
                {
                    Write($"{s},");
                }
                s = "";
            }
        }
    }
}
