using PrimeFactorsLib;
using System;
using static System.Console;

namespace Chapter04
{
    class Program
    {
        static void Main(string[] args)
        {
            int largest = 1000; // limit the largest original number entered
            string a = new PrimeFactors(largest, 4).Print();
            string b = new PrimeFactors(largest, 7).Print();
            string c = new PrimeFactors(largest, 30).Print();
            string d = new PrimeFactors(largest, 40).Print();
            string e = new PrimeFactors(largest, 50).Print();
            WriteLine(a);
            WriteLine(b);
            WriteLine(c);
            WriteLine(d);
            WriteLine(e);
        }
    }
}