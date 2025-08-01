using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tanna_sir
{
    /// <summary>
    /// This class includes important methods
    /// </summary>
    internal class swap
    {
        /// <summary>
        /// used to share % value
        /// </summary>
        int x;


        /// <summary>
        /// This method is used to swap values of two variables
        /// </summary>
        /// <param name="a">First ref parameter or variable</param>
        /// <param name="b">Second ref parameter or variable</param>
        static void Swap(ref int a,ref int b)  //a and b both are refrence parameters
        {
         
            //int temp = a;
            //a = b;
            //b = temp;

            //a=20 , b=10
            a = a + b;  
            b = a - b;
            a = a - b;

        }
        static void Main()
        {
            SwapMethod obj = new SwapMethod();
            obj.a = 1;
            int a = 10, b = 20;
            Console.WriteLine("Before Swap :a={0} and b={1}",a,b);

            Swap(ref a,ref b);
            Console.WriteLine("After Swap:a={0} and b={1}", a, b);
        }
    }
}
