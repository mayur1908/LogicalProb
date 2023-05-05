using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace FibonacciSerise
{
    public class FibonacciSeries
    {
        public static void FibonacciAndSeries()
        {
            int a = 0;
            int b = 1;
            int c = 0;
            Console.WriteLine(" enter the nth value ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.Write("{0} {1} ", a, b);
            for (int i = 2; i < n; i++)
            {
                c = a + b;
                Console.Write(" {0}", c);
                a = b;
                b = c;
            }
            Console.WriteLine("");
        }
    }
}
