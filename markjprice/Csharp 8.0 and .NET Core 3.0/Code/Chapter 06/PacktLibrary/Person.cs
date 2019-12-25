using System;
using System.Collections.Generic;
using static System.Console;

namespace Packt.Shared
{
    public class Person : IComparable<Person>
    {
        // fields
        public string Name;
        public DateTime DateOfBirth;
        public List<Person> Children = new List<Person>();

        // methods
        
        // static method
        public static Person Procreate (Person p1, Person p2)
        {
            var baby = new Person
            {
                Name = $"Baby of {p1.Name} and {p2.Name}"
            };
            p1.Children.Add(baby); // see public class List<T> ... public void Add(T item);
            p2.Children.Add(baby);
            return baby;
        }
        // instance method
        public Person ProcreateWith(Person partner)
        {
            return Procreate(this, partner);
        }
        public void WriteToConsole()
        {
            WriteLine(
                format: "{0} was born on a {1:ddd}.",
                Name,
                DateOfBirth
            );
        }
        public override string ToString()
        {
            return $"{Name} is a {base.ToString()}";
        }
        
        // operator to "multiply"
        public static Person operator *(Person p1, Person p2)
        {
            return Person.Procreate(p1, p2);
        }

        // method with a local function
        public static int Factorial(int number)
        {
            if (number < 0)
            {
                throw new ArgumentException(
                    $"{nameof(number)} cannot be less than zero."
                );
            }
            return localFactorial(number);

            int localFactorial(int localNumber) // local function
            {
                if (localNumber < 1) return 1;
                return localNumber * localFactorial(localNumber - 1);
            }
        }

        // inheriting exceptions
        public void TimeTravel(DateTime when)
        {
            if (when <= DateOfBirth)
            {
                throw new PersonException("you can't travel back in time before your birth!");
            }
            else
            {
                WriteLine($"Welcom to {when:yyyy}!");
            }
        }



        // defining and handling delegates
        // event delegate field
        public EventHandler Shout;
        // data field
        public int AngerLevel;
        // method
        public void Poke()
        {
            AngerLevel++;
            if (AngerLevel >= 3)
            {
                // if something is listening...
                if (Shout != null)
                {
                    // ...then call the delegate
                    Shout(this, EventArgs.Empty);
                }
            }
        }

        public int CompareTo(Person other)
        {
            return Name.CompareTo(other.Name);
        }

        // comparing object when sorting
    }
    public class PersonComparer : IComparer<Person>
    {
        public int Compare(Person x, Person y)
        {
            // compare the name lengths...
            int result = x.Name.Length.CompareTo(y.Name.Length);
            // ..if they are equal...
            if (result == 0)
            {
                // ...then compare by the names
                return x.Name.CompareTo(y.Name);
            }
            else
            {
                // otherwise compare by the lengths
                return result;
            }
        }
    }
}
