using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibonacheSerise
{
    public class PerfectNumber
    {
        public static void FindPerfectNumber()
        {
            int min, max, n, sum, i;
            Console.WriteLine("Find the perfect given number");
            n=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("input the starting range");
            min= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the ending range");
            max= Convert.ToInt32(Console.ReadLine());
            for(n = min; n <= max;n++)
            {
                i = 1;
                sum = 0;
                while(i<n)
                {
                    if(n%i == 0)
                        sum=sum+i;
                    i++;
                }
                if(sum==n)
                {
                    Console.WriteLine("{0}",n);
                }
            }
        }
    }
}
