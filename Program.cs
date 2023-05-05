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
        {   CreateStopWatch csw = new CreateStopWatch();
            // FibonacciSeries.FibonacciAndSeries();
            //PerfectNumber.FindPerfectNumber();
            //Reverse.ReverseNumber();
            //CheckPrime.CheckPrimeNumber();
            /* Console.WriteLine("Enter the n ");
             int n = Convert.ToInt32(Console.ReadLine());
             int count = CouponGenerator.GetDistinctCoupons(n);
             Console.WriteLine("Total random numbers needed to have all distinct coupons for n = " + n + " is " + count);
             */
            csw.StopWatch();
            Console.ReadKey();
        }
    }
}
