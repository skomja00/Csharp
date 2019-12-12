using System;

namespace Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            // // unsigned integer means positive whole number 
            // // including 0
            // uint naturalNumber = 23;

            // // integer means negative or psoitive whole number
            // // including 0
            // int integerNumber = -23;

            // // float means single-precision floating point
            // // F suffix makes it a float literal
            // float realNumber = 2.3F;

            // // double means double-precision floating point
            // double anotherRealNumber = 2.3;

            // Console.WriteLine($"uint={naturalNumber}, integerNumber={integerNumber}, realNumber={realNumber}, anotherRealNumber={anotherRealNumber}");
            
            // // three variables that store the number 2 million
            // int decNotation = 2_000_000;
            // int binNotation = 0b_0001_1110_1000_0100_1000_0000;
            // int hexNotation = 0x_001E_8480;

            // // check the three variables have the same value
            // // both statements output true
            // Console.WriteLine($"{decNotation == binNotation}");
            // Console.WriteLine($"{decNotation == hexNotation}");

            // writing code to explore number sizes
            Console.WriteLine($"float uses {sizeof(float)} bytes can store numbers in the range {float.MinValue:N0} to {float.MaxValue:N0}\n\n\n");
            Console.WriteLine($"double uses {sizeof(double)} bytes can store numbers in the range {double.MinValue:N0} to {double.MaxValue:N0}\n\n\n");
            Console.WriteLine($"decimal uses {sizeof(decimal)} bytes can store numbers in the range {decimal.MinValue:N0} to {decimal.MaxValue:N0}\n\n\n");

            // // comparing double and decimal types
            // Console.WriteLine("using doubles:");

            // double a = 0.1;
            // double b = 0.2;

            // if (a + b == 0.3) 
            // {
            //     Console.WriteLine($"{a} + {b} equals 0.3");
            // }
            // else
            // {
            //     Console.WriteLine($"{a} + {b} does not equal 0.3");

            // }

            // Console.WriteLine("using doubles:");

            // decimal c = 0.1M; // M suffix means a decimal literal value
            // decimal d = 0.2M;

            // if (c + d == 0.3M) 
            // {
            //     Console.WriteLine($"{c} + {d} equals 0.3");
            // }
            // else
            // {
            //     Console.WriteLine($"{c} + {d} does not equal 0.3");

            // }

        }
    }
}
