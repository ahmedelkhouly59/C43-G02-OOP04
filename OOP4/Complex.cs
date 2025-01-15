using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP4
{
    internal class Complex
    {
        public int Real {  get; set; }
        public int Img { get; set; }

        public Complex(int x,int y) {
            Real = x;
            Img = y;
        }    

        public Complex() { }

        public override string ToString()
        {
            return $"Real = {Real} , Img = {Img}";
        }
        public static Complex operator + (Complex a, Complex b) {
            return new Complex()
            {
                Real = a.Real + b.Real,
                Img = a.Img + b.Img,
            };
        }

        public static Complex operator -(Complex a, Complex b)
        {
            return new Complex()
            {
                Real = a.Real - b.Real,
                Img = a.Img - b.Img,
            };
        }
    }
}
