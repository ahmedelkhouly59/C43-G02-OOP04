using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP4
{
    internal class Rectangle
    {
        public int Width { get; set; }
        public int Height { get; set; }

        public Rectangle()
        {
            Width = 0;
            Height = 0;
        }

        public Rectangle(int height,int width)
        {
            Height = height;
            Width = width;
        }

        public Rectangle(int num)
        {
            Height=num;
            Width = num;
        }

        public override string ToString()
        {
            return $"Width = {Width} Height = {Height}";
        }
    }
}
