using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__OOB_L2
{
    public struct Point
    {
        int x1;
        int x2;
        int y1;
        int y2;
        
        public Point(int x1, int y1, int x2, int y2) // Parameterized constructor
        {
            this.x1 = x1;
            this.y1 = y1;
            this.x2 = x2;
            this.y2 = y2;
        }

        public double calculateDistance()
        {
            //d = √((x₂ -x₁)² +(y₂ -y₁)² ) 
            return Math.Sqrt(((x2 - x1) * (x2 - x1)) + ((y2 - y1) * (y2 - y1)));
        } 
        public static double calculateDistance(int x1, int y1, int x2, int y2)
        {
            //d = √((x₂ -x₁)² +(y₂ -y₁)² ) 
            return Math.Sqrt(((x2 - x1) * (x2 - x1)) + ((y2 - y1) * (y2 - y1)));
        } // Method to calculate the distance from the origin (0,0) to the point (x,y)
        public override string ToString()
        {
            return $"Point: x1 = {x1}, y1 = {y1}, x2 = {x2}, y2 = {y2}, Distance = {calculateDistance()}";
        } 
    }
}
