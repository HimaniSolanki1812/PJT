using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tanna_sir
{
    internal class MethodOverloadingDemo
    {
        // Method to sum two integers
        void Sum(int x, int y)
        {
            int result = x + y;
            Console.WriteLine("Sum of two numbers: " + result);
        }

        // Method to sum three integers
        void Sum(int x, int y, int z)
        {
            int result = x + y + z;
            Console.WriteLine("Sum of three numbers: " + result);
        }

        static void Main()
        {
            MethodOverloadingDemo obj = new MethodOverloadingDemo();

            // Calling method with 2 parameters
            obj.Sum(10, 20);       // Output: Sum of two numbers: 30

            // Calling method with 3 parameters
            obj.Sum(5, 15, 25);    // Output: Sum of three numbers: 45

            Console.ReadLine(); // Keep console window open
        }
    }
}
