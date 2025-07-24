using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tanna_sir
{
    internal class nineth_patten
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("enter number");
            int num = Convert.ToInt32(Console.ReadLine());
            string[] dig = { "zero ", "one ", "two ", "three ", "four ", "five ", "six ", "seven ", "eight ", "nine " };
            string result = null;
            while (num > 0)
            {
                int digit = num % 10;
                num = num / 10;
                result = dig[digit] + result;


            }
            Console.WriteLine(result);

        }
    }
}
