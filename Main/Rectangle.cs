using System;
using System.Collections.Generic;
using System.Text;

namespace Main
{
    public class Rectangle
    {
        public int Side_a { get; set; }

        public Rectangle(int size_a)
        {
            Side_a = size_a;
        }

        public int CalculateSquare()
        {
            return (int)Math.Pow(Side_a, 2);
        }

        public static int CalculateSquare(int side_a)
        {
            return (int)Math.Pow(side_a, 2);
        }
    }
}