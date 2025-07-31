using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__OOB_L2_Demo
{
    internal struct Point
    {
        public int x;
        public int y;

        #region Constructors

        // Constructors Overloading
        public Point() // Default constructor 
        {
            this.x = 10;
            this.y = 20;
        }
        public Point(int x, int y) // Parameterized constructor
        {
            this.x = x;
            this.y = y;
        }    
        public Point(Point p) // Copy constructor
        {
            this.x = p.x;
            this.y = p.y;
        }
        #endregion

        // Method to display the point with overloaded ToString method from object class 
        public override string ToString()
        {
            return $"Point: x = {x}, y = {y}";
        } 
    }
}
