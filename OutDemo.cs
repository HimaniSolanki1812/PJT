using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tanna_sir
{
    internal class OutDemo
    {
        static void Change(ref int a, ref int b) {
            a = 100;
            b = 200;
        }
        static void Update(out int x, out int y)
        {
            x = 100;
            y = 200;

        }


        static void Main()
        {
            int a = 10, b = 20;
            int x=10, y=20;
            Console.WriteLine("Before Swap :a={0} and b={1}", a, b);
            Change(ref a, ref b);
            Console.WriteLine("After Swap:a={0} and b={1}", a, b);

            Console.WriteLine("Before Swap :a={0} and b={1}", x, y);
            Update(out x, out y);
            Console.WriteLine("After Swap:a={0} and b={1}", x, y);


        }
    }
}
