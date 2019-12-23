using System;
using System.Collections.Generic;
using static System.Console;

namespace Packt.Shared
{
    public partial class Person
    {
        public string Name;
        public DateTime DateOfBirth;
        public WondersOfTheAncientWorld FavoriteAncientWonder;
        public WondersOfTheAncientWorld BucketList;
        public List<Person> Children = new List<Person>();
        public const string Species = "Homo Sapien";
        public readonly string HomePlanet = "Earth";
        public readonly DateTime Instantiated;

        // constructors
        public Person()
        {
            // set default values for fields
            // including read-only fields
            Name = "unknown";
            Instantiated = DateTime.Now;
        }
        public Person(string initialName, string homePlanet)
        {
            Name = initialName;
            HomePlanet = homePlanet;
            Instantiated = DateTime.Now;            
        }

        // tuple 
        public (string Name, int Number) GetFruit()
        {
            return (Name: "Apples", Number: 5);
        }

        public string OptionalParameters(
            string command = "Run!",
            double number = 0.0,
            bool active = true)
        {
            return string.Format(
                format: "command is {0}, number is {1}, active is {2}",
                command,
                number, 
                active);
        }
        public void PassingParameters(int x, ref int y, out int z) 
        {
            // out parameters cannot hvae a default
            // AND must be initialized inside the method
            z = 99;

            // increment each parameter
            x++;
            y++;
            z++;
        }
        public string FavoriteIceCream { get; set; } // auto-syntax

        // a property defined using C# 1.0 - 5.0 syntax
        public string Origin
        {
            get
            {
                return $"{Name} was born on {HomePlanet}";
            }
        }
        // two properties defined using C# 6.0 lambda expression
        public string Greeting => $"{Name} says 'Hello!'";
        public int Age => System.DateTime.Today.Year - DateOfBirth.Year;


        
        // settable properties
        private string favoritePrimaryColor;
        public string FavoritePrimaryColor 
        {
            get 
            {
                return favoritePrimaryColor;
            }
            set
            {
                switch (value.ToLower())
                {
                    case "red":
                    case "green":
                    case "blue":
                      favoritePrimaryColor = value;
                      break;
                    default:
                      throw new System.ArgumentException(
                          $"{value} not a primary color. Chose from: red, green, blue.");
                }
            }
        }
        // indexers
        public Person this[int index]
        {
            get
            {
                return Children[index];
            }
            set
            {
                Children[index] = value;
            }
        }
    }
}
