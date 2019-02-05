using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class Calculator
    {
        public double Add(double q, double b)
        {
            return q + b;
        }

        public double Subtract(double a, double b)
        {
            return a - b;
        }

        public double Multiply(double a, double c)
        {
            return a * c; 
        }

        public double Power(double x, double exp)
        {
            return Math.Pow(x, exp);
        }



    }
}
