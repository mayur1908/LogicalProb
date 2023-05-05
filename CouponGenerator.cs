using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibonacheSerise
{
    public class CouponGenerator
    {
        
            public static int GenerateRandomCoupon(int n)
            {
                /*
                Returns a random coupon number between 1 and n.
                */
                Random rnd = new Random();
                return rnd.Next(1, n + 1);
            }

            public static int GetDistinctCoupons(int n)
            {
                /*
                Returns the number of random coupons needed to have all distinct coupons.
                */
                HashSet<int> distinctCoupons = new HashSet<int>();
                int count = 0;

                while (distinctCoupons.Count < n)
                {
                    int coupon = GenerateRandomCoupon(n);
                    if (!distinctCoupons.Contains(coupon))
                    {
                        distinctCoupons.Add(coupon);
                    }
                    count++;
                }

                return count;
            }
        }
}
