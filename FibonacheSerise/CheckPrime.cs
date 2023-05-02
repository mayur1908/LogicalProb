using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibonacheSerise
{
    public class CheckPrime
    {
        public static void CheckPrimeNumber()
        {
            Console.WriteLine("Enter a number: ");
            int num = Convert.ToInt32(Console.ReadLine());
            bool isPrime = true;

            for (int i = 2; i <= Math.Sqrt(num); i++)
            {
                if (num % i == 0)
                {
                    isPrime = false;
                    break;
                }
            }

            if (num < 2)
            {
                isPrime = false;
            }

            if (isPrime)
            {
                Console.WriteLine(num + " is a prime number.");
            }
            else
            {
                Console.WriteLine(num + " is not a prime number.");
            }

        }
    }
}
