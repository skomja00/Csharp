using System;
using static System.Console;
using System.IO;

namespace SelectionStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            // if (args.Length == 0)
            // {
            //     WriteLine("There are no arguments.");
            // }
            // else
            // {
            //     WriteLine("This is at least one argument.");
            // }

            // // add and remove the "" to change the behavior
            // object o = 3;
            // int j = 4;
            // if (o is int i) // if o is an int assign it to local variable i
            // {
            //     WriteLine($"{i} * {j} = {i * j}");
            // }
            // else
            // {
            //     WriteLine("o is not an int so it cannot multiply!");
            // }

            // A_label:
            // var number = (new Random()).Next(1, 7);
            // WriteLine($"My random number is {number}");
            // switch (number)
            // {
            //     case 1:
            //       WriteLine("One");
            //       break; // justs to end of switch statement
            //     case 2:
            //       WriteLine("Two");
            //       goto case 1;
            //     case 3:
            //     case 4:
            //       WriteLine("Three or Four");
            //       goto case 1;
            //     case 5:
            //       // go to sleep for half a second
            //       System.Threading.Thread.Sleep(500);
            //       goto A_label;
            //     default:
            //       Write("Default");
            //       break;
            // } // end of switch statement

            string path = @"W:\Documents\source\Csharp\markjprice\Csharp 8.0 and .NET Core 3.0\Code\Chapter 03\SelectionStatements";
            Stream s = File.Open(
                Path.Combine(path, "file.txt"), FileMode.OpenOrCreate);
            string message = string.Empty;
            switch (s)
            {
                case FileStream writeableFile when s.CanWrite:
                  message = "The stream is a file that I can write to.";
                  break;
                case FileStream readOnlyFile:
                  message = "The stream is a read-only file.";
                  break;
                case MemoryStream memoryStream:
                  message = "The stream is a memory address.";
                  break;
                default: // always evaluate last despite it current position
                  message = "The stream is some other type.";
                  break;
                case null:
                  message = "The stream is null.";
                  break;
            };
            
            WriteLine(message);

            message = s switch
            {
                FileStream writeableFile when s.CanWrite
                  => "The stream is a file that I can write to.",
                FileStream readOnlyFile
                  => "The stream is a read-only file.",
                MemoryStream ms
                  => "The stream is a memory address.",
                null
                  => "The stream is null.",
                _
                  => "The stream is some other type."
            };
            
            WriteLine(message);
        }
    }
}
