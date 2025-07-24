using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tanna_sir
{
    internal class Third_patten
    {
        public static void Main(string[] args)
        {
            for(int i =5;i>0;i--)
            {
                for(int j = i;j>=1;j--)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
