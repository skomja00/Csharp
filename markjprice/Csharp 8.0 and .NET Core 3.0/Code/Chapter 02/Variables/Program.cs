using System;

namespace Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            // object height = 1.88; // storing a double in and object
            // object name = "Amir"; // storing a string in an object

            // Console.WriteLine($"{name} is {height} meters tall.");

            // // int length1 = name.Length; // gives compile error!
            // int length2 = ((string)name).Length; // tell compiler it is a string

            // Console.WriteLine($"{name} is {length2} characters.");

            // // storing a string in a dynamic object
            // dynamic anotherName = "Ahmed";

            // // this compile but would throw an exception at run-time
            // // if you later store a data type that does not have a 
            // // property named Length.
            // int dynLength = anotherName.Length;

            // Console.WriteLine($"{anotherName} is {dynLength} characters.");

            // // declaring local variables
            // int population = 66_000_000; // L suffix means a Long literal value
            // double weight = 1.88; // F  suffix means a Float literal value
            // decimal price = 4.99M; // M suffix means a Decimal literal value
            // string fruit = "Apples"; // strings use double-quotes
            // char letter = 'Z'; // chars use single-quoutes
            // bool happy = true; // Booleans have a value of true or false

            Console.WriteLine($"default(int) = {default(int)}");
            Console.WriteLine($"default(bool) = {default(bool)}");
            Console.WriteLine($"default(DateTime) = {default(DateTime)}");
            Console.WriteLine($"default(string) = {default(string)}");


        }
    }
}
