using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

public delegate double Function(double x);

namespace NUnitTDDTests
{
    internal class Calculator
    {

        public double Add(double a, double b)
        {
            return a + b;
        }

        public double Div(double a, double b)
        {
            if (Math.Abs(b) < double.Epsilon)
            {
                return double.NaN;
            }
            return a / b;
        }

        public double Pow(double a, double b)
        {
            return Math.Pow(a, b);
        }

        public int Fac(int n)
        {
            if (n == 0)
            {
                return 1;
            }
            else
            {
                return n * Fac(n - 1);
            }
        }

        private const double h = 0.0001;

        public static double Der(Function f, double x)
        {
            return (f(x + h) - f(x - h)) / (2 * h);
        }
    }
}