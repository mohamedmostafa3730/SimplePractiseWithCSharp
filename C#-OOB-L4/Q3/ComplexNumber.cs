using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace C__OOB_L4.Q3
{
    internal class ComplexNumber
    {

        private double num1;
        private double num2;

        public ComplexNumber(double real, double imaginary)
        {
            num1 = real;
            num2 = imaginary;
        }

        public static ComplexNumber operator +(ComplexNumber c1, ComplexNumber c2)
        {
            return new ComplexNumber(c1.num1 + c2.num1, c1.num2 + c2.num2);
        }

        public static ComplexNumber operator -(ComplexNumber c1, ComplexNumber c2)
        {
            return new ComplexNumber(c1.num1 - c2.num1, c1.num2 - c2.num2);
        }

        public override string? ToString()
        {
            if (num2 >= 0)
            {
                return $"{num1} + {num2}i";
            }
            else
            {
                return $"{num1} - {num2}i";
            }
        }
    }
}
