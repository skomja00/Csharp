using System;

namespace Exercise6_2
{
    public class Circle : Shape
    {
        public Circle (double radius)
        {
            width = radius * 2;
            height = radius * 2;
            area = Math.PI * Math.Pow(radius, 2);
        }
    }
}