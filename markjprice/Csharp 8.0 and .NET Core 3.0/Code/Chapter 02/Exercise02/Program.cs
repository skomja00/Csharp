using System;
using static System.Console;

namespace Exercise02
{
    class Program
    {
        static void Main(string[] args)
        {
            // my solution
            string hyphens = new String('-',76);
            Clear();
            WriteLine(hyphens);
            WriteLine("Type    Byte(s) of memory               Min                              Max");
            WriteLine(hyphens);
            WriteLine($"{"sbyte", -8}{sizeof(sbyte), -2:D}{sbyte.MinValue, 33:D}{sbyte.MaxValue, 31:D}");
            WriteLine($"{"byte", -8}{sizeof(byte), -2:D}{byte.MinValue, 33:D}{byte.MaxValue, 31:D}");
            WriteLine($"{"short", -8}{sizeof(short), -2:D}{short.MinValue, 33:D}{short.MaxValue, 31:D}");
            WriteLine($"{"ushort", -8}{sizeof(ushort), -2:D}{ushort.MinValue, 33:D}{ushort.MaxValue, 31:D}");
            WriteLine($"{"int", -8}{sizeof(int), -2:D}{int.MinValue, 33:D}{int.MaxValue, 31:D}");
            WriteLine($"{"uint", -8}{sizeof(uint), -2:D}{uint.MinValue, 33:D}{uint.MaxValue, 31:D}");
            WriteLine($"{"long", -8}{sizeof(long), -2:D}{long.MinValue, 33:F0}{long.MaxValue, 31:F0}");
            WriteLine($"{"ulong", -8}{sizeof(ulong), -2:D}{ulong.MinValue, 33:F0}{ulong.MaxValue, 31:F0}");
            WriteLine($"{"float", -8}{sizeof(float), -2:D}{float.MinValue, 33:E7}{float.MaxValue, 31:E7}");
            WriteLine($"{"double", -8}{sizeof(double), -2:D}{double.MinValue, 33:E16}{double.MaxValue, 31:E16}");
            WriteLine($"{"decimal", -8}{sizeof(decimal), -2:D}{decimal.MinValue, 33:F0}{decimal.MaxValue, 31:F0}");
            
            // price's solution
            WriteLine("--------------------------------------------------------------------------");
            WriteLine("Type    Byte(s) of memory               Min                            Max");
            WriteLine("--------------------------------------------------------------------------");
            WriteLine($"sbyte   {sizeof(sbyte),-4} {sbyte.MinValue,30} {sbyte.MaxValue,30}");
            WriteLine($"byte    {sizeof(byte),-4} {byte.MinValue,30} {byte.MaxValue,30}");
            WriteLine($"short   {sizeof(short),-4} {short.MinValue,30} {short.MaxValue,30}");
            WriteLine($"ushort  {sizeof(ushort),-4} {ushort.MinValue,30} {ushort.MaxValue,30}");
            WriteLine($"int     {sizeof(int),-4} {int.MinValue,30} {int.MaxValue,30}");
            WriteLine($"uint    {sizeof(uint),-4} {uint.MinValue,30} {uint.MaxValue,30}");
            WriteLine($"long    {sizeof(long),-4} {long.MinValue,30} {long.MaxValue,30}");
            WriteLine($"ulong   {sizeof(ulong),-4} {ulong.MinValue,30} {ulong.MaxValue,30}");
            WriteLine($"float   {sizeof(float),-4} {float.MinValue,30} {float.MaxValue,30}");
            WriteLine($"double  {sizeof(double),-4} {double.MinValue,30} {double.MaxValue,30}");
            WriteLine($"decimal {sizeof(decimal),-4} {decimal.MinValue,30} {decimal.MaxValue,30}");
            WriteLine("--------------------------------------------------------------------------");
        }
    }
}
