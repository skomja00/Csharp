using System;
using static System.Console;

namespace HandlingExceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Before parsing");
            Write("What is you age? ");
            string input = Console.ReadLine();
            try 
            {
                int age = int.Parse(input);
                WriteLine($"You are {age} years old. ");
            }
            catch (FormatException fex)
            {
                WriteLine($"FormatException: Age format invalid:\n...{fex.Message}");
            }
            catch (OverflowException oex)
            {
                WriteLine($"OverflowException: Age format valid but...\n...{oex.Message}");
            }
            catch (Exception ex)
            {
                WriteLine($"AllException:\n...{ex.GetType()} is {ex.Message}");
            }
            WriteLine("After parsing.");
        }
    }
}
