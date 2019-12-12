#nullable enable
using System;

namespace NullHandling
{
    class Address 
    {
        public string? Building;
        public string Street = string.Empty;
        public string City = string.Empty;
        public string Region = string.Empty;

        public void print (Address a) 
        {
            Console.WriteLine($"Street={Street} Bldg={Building}\nCity={City}, Region={Region}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
        //     //int thisCannotBeNull = 4;
        //     //thisCannotBeNull = null; // compile error!
        //     int? thisCouldBeNull = null;
        //     Console.WriteLine(thisCouldBeNull);
        //     Console.WriteLine(thisCouldBeNull.GetValueOrDefault());
        //     thisCouldBeNull = 7;
        //     Console.WriteLine(thisCouldBeNull);
        //     Console.WriteLine(thisCouldBeNull.GetValueOrDefault());

        // var address = new Address();
        // address.Building = null;
        // address.Street = "Ruth Ave";
        // address.City = "Phoenixville";
        // address.Region = "Greater Philadelphia";
        // address.print(address);

        string authorName = null;
        // //int x = authorName.Length; // throws NullReferenceException
        int? y = authorName?.Length; // instead of NullReferenceException y assigned null

        // reslut will be 3 if aothorName?.Length is null
        var result = authorName?.Length ?? 3;
        Console.WriteLine(result);
        }
    }
}
