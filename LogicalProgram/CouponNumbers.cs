using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgram
{
    public class CouponNumbers
    {
        public static void GetCoupon()
        {
            
            

            Console.WriteLine("Enter number for Distint Coupon Number :");
            int numCoupons = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the Length of Coupon :");
            int couponLength = Convert.ToInt32(Console.ReadLine());

            int numIteration = 0;
            int index = 0;

            int[] arr = new int[numCoupons];    

            while (numCoupons > 0)
            {
                Random random = new Random();
                couponLength = random.Next(couponLength);
                int rand = random.Next(couponLength);
                numIteration++;
                if (arr.Contains(rand) != true)
                {
                    arr[index] = rand;
                    index++;
                    numCoupons--;
                }
                
                Console.WriteLine(rand);
            }

            foreach (var item in arr)
            {
                Console.WriteLine("Coupon : " + Convert.ToString(item));
            }
            Console.WriteLine("Number of iteration " + numIteration);
        }
    }
}
