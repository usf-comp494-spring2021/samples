using System;

namespace CalcLib
{
    /// <summary>
    /// This class is responible for maintaining the core
    /// calculator structure and logic
    /// </summary>
    public class Calculator
    {

        /// <summary>
        /// This method will add two provided numbers
        /// </summary>
        /// <param name="a">Provided double a</param>
        /// <param name="b">Provided double b</param>
        /// <returns>The sum of a and b</returns>
        public double Add(double a, double b)
        {
            return (a + b);
        }

        /// <summary>
        /// This method will subtract two provided numbers
        /// </summary>
        /// <param name="a">Provided double a</param>
        /// <param name="b">Provided double b</param>
        /// <returns>The difference of a and b (a-b)</returns>
        public double Subtract(double a, double b)
        {
            return (a - b);
        }

        /// <summary>
        /// This method will multiply two provided numbers
        /// </summary>
        /// <param name="a">Provided double a</param>
        /// <param name="b">Provided double b</param>
        /// <returns>The product of a and b</returns>
        public double Multiply(double a, double b)
        {
            return(a * b);
        }

        /// <summary>
        /// This method will divide two provided numbers
        /// </summary>
        /// <param name="a">Provided double a</param>
        /// <param name="b">Provided double b</param>
        /// <returns>The quotient of a and b (a / b)</returns>
        public double Divide(double a, double b)
        {
            return (a / b);
        }
    }
}
