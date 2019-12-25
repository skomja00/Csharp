using System;

namespace Exercise6_2
{
    public class Rectangle : Shape
    {
        public Rectangle(double w, double h)
        {
            width = w;
            height = h;
            area = width * height;
        }
    }
}