using System;
using static System.Console;

namespace Week3
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Hello World!");

            int x = 10;
            Console.WriteLine($"The value of x is: {x.ToString()}. X is of type {x.GetType()}");
            
            double y = 10.0001;
            Console.WriteLine($"The value of y is: {y.ToString("C")}. X is of type {y.GetType()}");

            //int z = y;
            //Console.WriteLine($"The value of z is: {z.ToString()}. z is of type {z.GetType().ToString()}");

            int z1 = (int)y;
            Console.WriteLine($"The value of z1 is: {z1.ToString()}. z is of type {z1.GetType().ToString()}");

            for (int i = 0; i <= 10; i++)
            {
                WriteLine($"The value of I is: {i}");
            }

            System.Collections.ObjectModel.Collection<int> intCollection = new System.Collections.ObjectModel.Collection<int>();
            intCollection.Add(123);

            /*
             * 
             * 
             * 
             * 
             * Code
            */

            WriteLine(intCollection.Count.ToString());
            




        }
    }
}
