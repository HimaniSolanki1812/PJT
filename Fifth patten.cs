using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tanna_sir
{
    internal class Fifth_patten
    {
        public static void Main(string[] args)
        {
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            for(int h= 5;h>0;h--)
            {
                for(int k = h;k>=1; k--)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
