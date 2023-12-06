using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

// Delegate representing a mathematical function that takes a double parameter and returns a double
public delegate double Function(double x);

namespace NUnitTDDTests
{
    // Calculator class with various mathematical operations
    internal class Calculator
    {
        // Method to perform division operation
        public double Div(double a, double b)
        {
            // Check if the divisor is close to zero to avoid division by nearly zero
            if (Math.Abs(b) < double.Epsilon)
            {
                // If divisor is close to zero, return NaN (Not a Number)
                return double.NaN;
            }
            // Perform the division and return the result
            return a / b;
        }

        // Method to perform exponentiation operation
        public double Pow(double a, double b)
        {
            // Use Math.Pow to calculate a raised to the power of b
            return Math.Pow(a, b);
        }

        // Method to calculate the factorial of a given integer
        public int Fac(int n)
        {
            // Base case: factorial of 0 is 1
            if (n == 0)
            {
                return 1;
            }
            // Recursive case: calculate factorial using recursion
            else
            {
                return n * Fac(n - 1);
            }
        }

        // Constant representing a small value used in numerical differentiation
        private const double h = 0.0001;

        // Static method to calculate the numerical derivative of a function at a given point
        public static double Der(Function f, double x)
        {
            // Numerical differentiation using the central difference formula
            return (f(x + h) - f(x - h)) / (2 * h);
        }
    }
}