using System;

namespace Exercise6_2
{
    public class Square : Shape
    {
        public Square(double side)
        {
            width = side;
            height = side;
            area = Math.Pow(side, 2);
        }
    }
}