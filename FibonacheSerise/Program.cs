using FibonacciSerise;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibonacheSerise
{
    public class Program
    {
        
        static void Main(string[] args)
        {
            FibonacciSeries.FibonacciAndSeries();
            PerfectNumber.FindPerfectNumber();
            Reverse.ReverseNumber();
            CheckPrime.CheckPrimeNumber();

            Console.ReadKey();
        }
    }
}
