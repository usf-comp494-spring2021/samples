using CalcLib;
using System;
using Xunit;

namespace CalcLibTest
{
    /// <summary>
    /// This class is responible for maintaining the testing structure
    /// to be ran against the Calculator Class
    /// </summary>
    public class CalculatorTest
    {

        /// <summary>
        /// This method will test the Calculator class Add method
        /// Test values a: 22, b: 44, Expected: 66
        /// </summary>
        [Fact]
        public void TestAdd22And44()
        {
            // Arrange
            double a = 22;
            double b = 44;
            double expected = 66;

            var calc = new Calculator();

            // Act
            double actual = calc.Add(a, b);

            // Assert
            Assert.Equal(expected, actual);
        }

        /// <summary>
        /// This method will test the Calculator class Subtract method
        /// Test values a: 20, b: 9, Expected: 11
        /// </summary>
        [Fact]
        public void TestSubtact20And9()
        {
            // Arrange
            double a = 20;
            double b = 9;
            double expected = 11;

            var calc = new Calculator();

            // Act
            double actual = calc.Subtract(a, b);

            // Assert
            Assert.Equal(expected, actual);
        }

        /// <summary>
        /// This method will test the Calculator class Multiply method
        /// Test values a: 9, b: 10, Expected: 90
        /// </summary>
        [Fact]
        public void TestMultiply9And10()
        {
            // Arrange
            double a = 9;
            double b = 10;
            double expected = 90;

            var calc = new Calculator();

            // Act
            double actual = calc.Multiply(a, b);

            // Assert
            Assert.Equal(expected, actual);
        }

        /// <summary>
        /// This method will test the Calculator class Divide method
        /// Test values a: 100, b: 5, Expected: 20
        /// </summary>
        [Fact]
        public void TestDivide100And5()
        {
            // Arrange
            double a = 100;
            double b = 5;
            double expected = 20;

            var calc = new Calculator();

            // Act
            double actual = calc.Divide(a, b);

            // Assert
            Assert.Equal(expected, actual);
        }
    }
}
