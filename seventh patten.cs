using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tanna_sir
{
    internal class seventh_patten
    {
        public static void Main(string[] args)
        {
            int a = 5;
            int b = 5;
            int res = ++a + b++ + b++ + a++ + ++a + ++b + a++;
            Console.WriteLine(res);
        }
    }
}
