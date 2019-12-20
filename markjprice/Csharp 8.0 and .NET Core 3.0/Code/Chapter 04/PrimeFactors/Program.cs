using PrimeFactorsLib;
using System;
using static System.Console;

namespace Chapter04
{
    class Program
    {
        static void Main(string[] args)
        {
            PrimeFactors a = new PrimeFactors(4);
            PrimeFactors b = new PrimeFactors(7);
            PrimeFactors c = new PrimeFactors(30);
            PrimeFactors d = new PrimeFactors(40);
            PrimeFactors e = new PrimeFactors(50);
            WriteLine(a.Print());
            WriteLine(b.Print());
            WriteLine(c.Print());
            WriteLine(d.Print());
            WriteLine(e.Print());
        }
    }
}