using System;
using Packt.Shared;
using static System.Console;

namespace PeopleApp
{
    class Program : Object
    {
        static void Main(string[] args)
        {
            var bob = new Person();
            bob.Name = "Bob Smith";
            bob.DateOfBirth = new DateTime(1965, 12, 22);
            bob.BucketList = 
                WondersOfTheAncientWorld.HangingGardensOfBabylon
                | 
                WondersOfTheAncientWorld.MausoleumAtHalicarnassus;
            bob.Children.Add(new Person {Name = "Alfred"});
            bob.Children.Add(new Person {Name = "Zoe"});
            bob.WriteToConsole();


            var alice = new Person 
            {
                Name = "Alice Jones",
                DateOfBirth = new DateTime(1998, 3, 7)
            };
            alice.WriteToConsole();

            BankAccount.InterestRate = 0.012M; // store a shared value
            var jonesAccount = new BankAccount();
            jonesAccount.AccountName = "Mrs. Jones";
            jonesAccount.Balance = 2400;

            var gerrierAccount = new BankAccount();
            gerrierAccount.AccountName = "Mr. Gerrier";
            gerrierAccount.Balance = 98;

            var blankPerson = new Person();
            WriteLine(
                format: "{0} of {1} was created at {2:hh:mm:ss} on a {2:dddd}",
                blankPerson.Name,
                blankPerson.HomePlanet,
                blankPerson.Instantiated
            );

            var gunny = new Person("Gunny", "Mars");
            WriteLine(
                format: "{0} of {1} was created at {2:hh:mm:ss} on a {2:dddd}.",
                gunny.Name,
                gunny.HomePlanet,
                gunny.Instantiated
            );

            var fruit = bob.GetFruit();
            WriteLine($"{fruit.Name}, {fruit.Number} there are.");

            var thing1 = ("Neville", 4);
            WriteLine($"{thing1.Item1}, {thing1.Item2} there are.");
            var thing2 = (bob.Name, bob.Children.Count);
            WriteLine($"{thing2.Name}, {thing2.Count} there are.");

            // // store return value in a typle variable with two fields
            // (string name, int age) tupleWithNamedFields = GetPerson();
            // // typleWithNamedFields.name
            // // typleWithNamedFields.age

            // // deconstruct return value into two separate variables
            // (string name, int age) = GetPerson();
            // // name
            // // age

            (string fruitName, int fruitNumber) = bob.GetFruit();
            WriteLine($"deconstructed: {fruitName}, {fruitNumber}");

            // command is Run!, number is 0, active is True
            WriteLine(bob.OptionalParameters());
            
            // command is jump!, number is 98.5, active is True
            WriteLine(bob.OptionalParameters("Jump!", 98.5)); 

            // command is Hide!, number is 52.7, active is True

            WriteLine(bob.OptionalParameters(number: 52.7, command: "Hide!")); 

            int a = 10;
            int b = 20;
            int c = 30;
            WriteLine($"before a={a}, b={b}, c={c}");
            bob.PassingParameters(a, ref b, out c);
            WriteLine($"after a={a}, b={b}, c={c}");

            var sam = new Person 
            {
                Name = "Sam",
                DateOfBirth = new DateTime(1972, 1, 27)
            };

            WriteLine(sam.Origin);
            WriteLine(sam.Greeting);
            WriteLine(sam.Age);

            sam.FavoriteIceCream = "Chocolate Fudge";
            WriteLine($"Sam's favorite ice-cream flavor is {sam.FavoriteIceCream}.");
            sam.FavoritePrimaryColor = "Red";
            WriteLine($"Sam's favorite primary color is {sam.FavoritePrimaryColor}.");


            // indexers
            sam.Children.Add(new Person {Name = "Charlie"});
            sam.Children.Add(new Person {Name = "Ella"});
            WriteLine($"Sam's first child is {sam.Children[0].Name}");
            WriteLine($"Sam's second child is {sam.Children[1].Name}");

        }
    }
}
