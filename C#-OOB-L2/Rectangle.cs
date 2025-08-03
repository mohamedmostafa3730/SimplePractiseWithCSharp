using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__OOB_L2
{
    internal struct Rectangle
    {
        private double Length;
        private double Width;
        private readonly double Area;
        public Rectangle()
        {
            Length = 1.0;
            Width = 1.0;
        }
        public Rectangle(double length, double width)
        {
            Length = length;
            Width = width;
        }

        public double GetLength()
        {
            return this.Length;
        }
        public double GetWidth()
        {
            return this.Length;
        }
        public void SetLength(double Length)
        {
            if (Length < 0) {
                Console.WriteLine("Length cannot be negative.");
            }
            else
            {
                this.Length = Length;
            }
        }
        public void SetWidth(double Width)
        {
            if (Width < 0)
            {
                Console.WriteLine("Width cannot be negative.");
            }
            else
            {
                this.Width = Width;
            }
        }

        public double GetArea()
        {
            return Length * Width;
        }





    }
}
