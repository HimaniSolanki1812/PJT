using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tanna_sir
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            for (int i = 1;i <= 5;i++)
            {
                for(int j = 1;j<=5;j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
