

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tanna_sir
{
    internal class sixth_patten
    {
        public static void Main(string[] args)
        {
            for (int i = 1; i <= 9; i++)
            {
                int k = i <= 5 ? i : 10 - i;
                for (int j = 1; j <= k; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            //for (int i = 1; i <= 10; i++)
            //{

            //    for (int j = 1; j <= 10; j++)
            //    {
            //        int k = i * j;
            //        Console.Write(i + "*" + j + "=" + k + "\t");
            //    }
            //    Console.WriteLine();

            //}


        }
    }

}
