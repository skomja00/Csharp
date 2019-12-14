using System;
using static System.Console;
using static System.Convert;

namespace CastingConverting
{
    class Program
    {
        static void Main(string[] args)
        {
            // int a = 10;
            // double b = a; // an in t can be safely cast into a double
            // WriteLine(b);
            // double c = 9.8;
            // int d = (int) c; // d is 9 losing the .8 part
            // WriteLine(d);

            // long e = 10;
            // int f = (int) e;
            // WriteLine($"e is {e:N0} and f is {f:N0}");

            // e = 5_000_000_000; // long.MaxValue;
            // f = (int) e;
            // WriteLine($"e is {e:N0} and f is {f:N0}");

            // double g = 9.8;
            // int h = ToInt32(g);
            // WriteLine($"g is {g} and h is {h}");

            // "bankers rounding" if midpoint and odd, down if midpoint even
            // double [] doubles = new[] { 9.49, 9.5, 9.51, 10.49, 10.5, 10.51 };
            // foreach(double d in doubles)
            // {
            //     WriteLine($"ToInt({d}) is {ToInt32(d)}");
            // }

            // // "away from zero rounding" rounding up at midpoint
            // double [] doubles = new[] { 9.49, 9.5, 9.51, 10.49, 10.5, 10.51 };
            // foreach(double d in doubles)
            // {
            //     WriteLine(
            //         format: "Math.Round({0}, 0, MidpointRounding.AwayFromZero) is {1}",
            //         arg0: d,
            //         arg1: Math.Round(value: d,
            //                          digits: 0,
            //                          mode: MidpointRounding.AwayFromZero));
            // }

            // converting from any type to a string
            // int number = 12;
            // WriteLine(number.ToString());
            // bool boolean = true;
            // WriteLine(boolean.ToString());
            // DateTime now = DateTime.Now;
            // WriteLine(now.ToString());
            // object me = new object();
            // WriteLine(me.ToString());

        //     // allocate array of 128 bytes
        //     byte[] binaryObject = new byte[128];
        //    // populate array with random bytes
        //    (new Random()).NextBytes(binaryObject);
        //    WriteLine("Binary object as bytes:");
        //    for (int index = 0; index < binaryObject.Length; index++)
        //    {
        //        Write($"{binaryObject[index]:X}");
        //    } 
        //    WriteLine();
        //    // convert to Base64 string and output as text
        //    string encoded = Convert.ToBase64String(binaryObject);
        //    WriteLine($"Binary Object as Base64; {encoded}");

        // parsing from strings to numbers or dates and times
        int age = int.Parse("52");
        DateTime birthday = DateTime.Parse("1 Janyuary 1968");
        WriteLine($"I was born {age} years ago.");
        WriteLine($"My birthday is {birthday}.");
        WriteLine($"My birthday is {birthday:D}.");
        }
    }
}