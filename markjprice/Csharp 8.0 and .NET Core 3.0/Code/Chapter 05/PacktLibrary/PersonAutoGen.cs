namespace Packt.Shared
{
    public partial class Person
    {
        // When working on large project with multiple team membes, split the 
        // definition of a complex class across multiple files. You do this 
        // using the 'partial' keyword.
        
        public void WriteToConsole() 
        {
            System.Console.WriteLine(
                format: "{0}\n\tis a {3} born {4} on {1:ddd, d MMMM yyyy}\n\tAncientWonder(s) is {2}.",
                this.Name,
                this.DateOfBirth,
                this.BucketList,
                Species,
                HomePlanet);
            for (int child = 0; child < this.Children.Count; child++)
            {
                System.Console.WriteLine(
                    format: "\tchild {0} is {1}",
                    child + 1,
                    this.Children[child].Name);
            }
        }
    }
}