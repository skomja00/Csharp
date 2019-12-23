﻿using System;
using Packt.Shared;
using static System.Console;

namespace PeopleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var harry = new Person {Name = "Harry"};
            var mary = new Person {Name = "Mary"};
            var jill = new Person {Name = "Jill"};

            // call the instance method
            var baby1 = mary.ProcreateWith(harry);

            // call the static method
            var baby2 = Person.Procreate(harry, jill);

            // call an operator
            var baby3 = harry * mary;

            WriteLine($"{harry.Name} has {harry.Children.Count} children. ");
            WriteLine($"{mary.Name} has {mary.Children.Count} children. ");
            WriteLine($"{jill.Name} has {jill.Children.Count} children. ");

            WriteLine(
                format: "{0}'s first child is named \"{1}\".",
                arg0: harry.Name,
                arg1: harry.Children[0].Name
            );

            WriteLine($"5! is {Person.Factorial(5)}");

            // defining and hanlding delegates
            harry.Shout = Harry_Shout;
            harry.Poke();
            harry.Poke();
            harry.Poke();
            harry.Poke();

            Person[] people = 
            {
                new Person { Name = "Simon"},
                new Person { Name = "Jenny"},
                new Person { Name = "Adam"},
                new Person { Name = "Richard"},
            };
            foreach (var person in people)
            {
                WriteLine($"{person.Name}");
            }
            // Use Person's IComparable implmentation to sort:
            WriteLine("Use Person's IComparable implementatjoin to sort:");
            Array.Sort(people);
            foreach (var person in people)
            {
                WriteLine($"{person.Name}");
            }

            WriteLine("use PersonComparer's IComparer implementation to sort:");
            Array.Sort(people, new PersonComparer());
            foreach (var person in people)
            {
                WriteLine($"{person.Name}");
            }

            // working with generic types
            // pre C# 2.0
            var t1 = new Thing();
            t1.Data = 42;
            WriteLine($"Thing with an integer: {t1.Process(42)}");

            var t2 = new Thing();
            t2.Data = "apple";
            WriteLine($"Thing with a string: {t2.Process("apple")}");

            // C# 2.0
            var gt1 = new GenericThing<int>();
            gt1.Data = 42;
            WriteLine($"GenericThing with an integer: {gt1.Process(42)}");

            var gt2 = new GenericThing<string>();
            gt2.Data = "apple";
            WriteLine($"GenericThing with a string: {gt2.Process("apple")}");

            // working with generic methods
            string number1 = "4";
            WriteLine(
                format: "{0} squared is {1}",
                arg0: number1,
                arg1: Squarer.Square<string>(number1)
            );

            byte number2 = 3;
            WriteLine(
                format: "{0} squared is {1}",
                arg0: number2,
                arg1: Squarer.Square<byte>(number2)
            );
        }
        // defining and hanlding delegates
        private static void Harry_Shout(Object sender, EventArgs e)
        {
            Person p = (Person)sender;
            WriteLine($"{p.Name} is this angry: {p.AngerLevel}.");
        }
    }
}
