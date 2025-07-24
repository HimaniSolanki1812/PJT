using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Tanna_sir
{
    internal class twelveth_patten
    {
        static int Add(int a, int b)
        {
            return a + b;
        }
        static int Sub(int a, int b)
        {
            return a - b;
        }
        static int Mul(int a, int b)
        {
            return a * b;
        }
        static int Div(int a, int b)
        {
            return a / b;
        }



        //can not use non-static members within static method
        //

        static void Main() //static 
            {
                int a = 20, b = 10;
               
                int ra=Add(a, b);
                Console.WriteLine("Addition:"+ra);
                int sub = Sub(a, b);
                Console.WriteLine("Substraction:" + sub);
                int mul = Mul(a, b);
                Console.WriteLine("Multiplication:" + mul);
                int div = Div(a, b);
                Console.WriteLine("Division:" + div);


        }

    }
    }

