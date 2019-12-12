using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names; // can reference any array of strings
            names = new string[4]; // allocate memory for 4 strings in an array
            names[0] = "Kate";
            names[1] = "Jack";
            names[2] = "Rebecca";
            names[3] = "Tom";
            for (int i = 0; i < names.Length; i++) {
                Console.WriteLine($"{names[i]}");
            }
        }
    }
}