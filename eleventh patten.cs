using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tanna_sir
{
    internal class eleventh_patten
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            int n = int.Parse(Console.ReadLine());

            int rows = n + 1; // rows = n + 1 to match the pattern
            int cols = 3;     // always 3 columns

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (i == 0 || i == rows - 1)
                    {
                        Console.Write(n);
                    }
                    else if (j == 0 || j == cols - 1)
                    {
                        Console.Write(n);
                    }
                    else
                    {
                        Console.Write(i);
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
