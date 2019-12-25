using System;
using static System.Console;

namespace Exercise6_2
{
    class Program
    {
        static void Main(string[] args)
        {
            var r = new Rectangle(3, 4.5);
            WriteLine(
                format: "{0,-25} {1,10} H:{2,10}, W:{3,10}, Area:{4,10:E2}",
                r.ToString(),
                nameof(r),
                r.height,
                r.width,
                r.area
            );
            var s = new Square(5);
            WriteLine(
                format: "{0,-25} {1,10} H:{2,10}, W:{3,10}, Area:{4,10:E2}",
                s.ToString(),
                nameof(s),
                s.height,
                s.width,
                s.area
            );
            var c = new Circle(2.5);
            WriteLine(
                format: "{0,-25} {1,10} H:{2,10}, W:{3,10}, Area:{4,10:E2}",
                c.ToString(),
                nameof(c),
                c.height,
                c.width,
                c.area
            );               
        }
    }
}
