using System;
using static System.Console;

/// <summary>
/// Title: Homework 2 Solution
/// Purpose: Build an array of numbers and determine
///          if the number within the array is even or odd.
///          The results will be output to the console.
///          NOTE: This contains three different possible solutions
/// </summary>
namespace Homework2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Possible Solution A
            Console.WriteLine("Posible Solution A (Using predefined intList)");

            //Prepare an array of ints
            int[] intList = { 1, 5, 10, 20, 40, 50, 650, 1222, 10200, 30900 };

            //Loop through array (Note: This will loop through as many times as the size of the array. This is a more dynmic code set
            foreach (int number in intList)
            {
                if (number % 2 == 0)
                    Console.WriteLine($"{number} is even.");
                else
                    Console.WriteLine($"{number} is odd.");
            }

            //Possible Solution B (We will start with the int list already built)
            Console.WriteLine("Posible Solution B (Using predefined intList)");

            //This will loop through only 10 times based on the for loop condition. This is a more rigid code set
            for (int i = 0; i < 10; i++)
            {
                if (intList[i] % 2 == 0)
                    Console.WriteLine($"{intList[i]} is even.");
                else
                    Console.WriteLine($"{intList[i]} is odd.");
            }

            //Possible Solution B (Using Random Number Generation 10 times (If you are familar)
            Console.WriteLine("Posible Solution C (Using Random 10 Times)");

            //This will only run 10 times
            int[] intList2 = new int[10];

            for (int i = 0; i < 10; i++)
            {
                Random random = new Random();
                int num = random.Next();
                intList2[i] = num;
                
                if (intList2[i] % 2 == 0)
                    Console.WriteLine($"{intList2[i]} is even.");
                else
                    Console.WriteLine($"{intList2[i]} is odd.");
            }

        }
    }
}
