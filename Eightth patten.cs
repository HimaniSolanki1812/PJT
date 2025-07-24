using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tanna_sir
{
    internal class Eightth_patten
    {
        public static void Main(string[] args)
        {
            {
                Console.Write("Input number of terms: ");
                int terms = Convert.ToInt32(Console.ReadLine());

                Console.Write("Input number: ");
                int num = Convert.ToInt32(Console.ReadLine());

                int sum = 0, t = 0;

                for (int i = 0; i < terms; i++)
                {
                    t = t * 10 + num;
                    Console.Write(t);
                    sum += t;
                    if (i != terms - 1)
                        Console.Write(" + ");
                }

                Console.WriteLine("\nThe Sum is : " + sum);

            }
        }
    }
}