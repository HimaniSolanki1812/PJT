using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tanna_sir
{
    internal class swap
    {
        static void Swap(ref int a,ref int b)
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
            int a = 10, b = 20;
            Console.WriteLine("Before Swap :a={0} and b={1}",a,b);
            Swap(ref a,ref b);
            Console.WriteLine("After Swap:a={0} and b={1}", a, b);
        }
    }
}
