using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tanna_sir
{
    internal class tenth_patten
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter the Mobile Number:");
            string mobile = Console.ReadLine();

            if (mobile.Length >= 5);
            string masked = mobile.Substring(0, mobile.Length - 5) + "XXXXX";
            Console.Write(masked);
        }


    }
}
