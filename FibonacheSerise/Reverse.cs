using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibonacheSerise
{
    public class Reverse
    {
        public static void ReverseNumber()
        {
            int rev=0, rem, n;
            Console.WriteLine("enter the n value");

             n=Convert.ToInt32(Console.ReadLine());
            while(n!=0)
            {
               rem = n%10;
               rev = rev*10+rem;
                n=n/10;
            }
            Console.WriteLine("{0}", rev);
        }
    }
}
