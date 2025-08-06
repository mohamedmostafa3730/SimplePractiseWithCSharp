using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__OOB_L4.Q1
{
    internal class Calculator
    {   /* Q1) Write a class named Calculator that contains a method named Add.
                Overload the Add method to:
            ● Accept two integers and return their sum.
            ● Accept three integers and return their sum.
            ● Accept two doubles and return their sum. */
        public static int Add(int a, int b)
        {
            return a + b;
        }
        public static int Add(int a, int b, int c)
        {
            return a + b + c;
        }
        public static int Add(double a, double b)
        {
            return (int)(a + b);
        }

    }
}
