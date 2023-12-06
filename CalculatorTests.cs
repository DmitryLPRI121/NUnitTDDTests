using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace NUnitTDDTests
{
    // Test class for the Calculator class using NUnit framework
    internal class CalculatorTests
    {
        // Instance of the Calculator class to be tested
        private Calculator calculator;

        // Setup method executed before each test to initialize the Calculator instance
        [SetUp]
        public void Setup()
        {
            calculator = new Calculator();
        }

        // Test method for the Div operation with multiple test cases
        [TestCase(25, 5, 5)]
        [TestCase(5, 2.5, 2)]
        [TestCase(-1, 5, -0.2)]
        [TestCase(-4, -1, 4)]
        [TestCase(5, 0, double.NaN)]
        public void TestDiv(double a, double b, double expected)
        {
            // Call the Div method and assert the result
            var result = calculator.Div(a, b);
            Assert.AreEqual(expected, result);
        }

        // Test method for the Pow operation with multiple test cases
        [TestCase(4, 3, 64)]
        [TestCase(3, 0, 1)]
        [TestCase(5, -1, 0.2)]
        [TestCase(-5, -1, -0.2)]
        [TestCase(25, 0.5, 5)]
        public void TestPow(double a, double b, double expected)
        {
            // Call the Pow method and assert the result
            var result = calculator.Pow(a, b);
            Assert.AreEqual(expected, result);
        }

        // Test method for the Fac operation with multiple test cases
        [TestCase(1, 1)]
        [TestCase(3, 6)]
        [TestCase(5, 120)]
        [TestCase(7, 5040)]
        [TestCase(10, 3628800)]
        public void TestFac(int n, int expected)
        {
            // Call the Fac method and assert the result
            var result = calculator.Fac(n);
            Assert.AreEqual(expected, result);
        }

        // Test method for the Der operation with a custom function and expected derivatives
        [Test]
        public void TestDer()
        {
            // Define a sample function for testing the derivative
            Function myFunction = x => 2 * x * x + 3 * x + 1;

            // Define expected derivative values at specific points
            double expectedDerivativeAt1 = 7.0;
            double expectedDerivativeAt2 = 11.0;
            double expectedDerivativeAt3 = 15.0;

            // Calculate actual derivatives using the Calculator's Der method
            double actualDerivativeAt1 = Calculator.Der(myFunction, 1.0);
            double actualDerivativeAt2 = Calculator.Der(myFunction, 2.0);
            double actualDerivativeAt3 = Calculator.Der(myFunction, 3.0);

            // Assert the calculated derivatives against the expected values with a tolerance of 0.001
            Assert.AreEqual(expectedDerivativeAt1, actualDerivativeAt1, 0.001);
            Assert.AreEqual(expectedDerivativeAt2, actualDerivativeAt2, 0.001);
            Assert.AreEqual(expectedDerivativeAt3, actualDerivativeAt3, 0.001);
        }
    }
}