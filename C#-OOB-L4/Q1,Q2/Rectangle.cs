using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__OOB_L4.Q1
{
    internal class Rectangle
    { /* Q2) Create a class named Rectangle with the following constructors:
          ● A parameterless constructor that sets the width and height to 0.
          ● A constructor that accepts width and height as integers.
          ● A constructor that accepts a single integer and sets both width and height to that value.*/
   
        public int Width { get; set; }
        public int Height { get; set; }
        public Rectangle(int width, int height)
        {
            Width = width;
            Height = height;
        }
        public Rectangle(int size)
        {
            Width = size;
            Height = size;
        }
    }
}
