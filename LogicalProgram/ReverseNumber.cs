using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgram
{
    public class ReverseNumber
    {
        public static void GetRevers()
        {
            int lastDigit;
            int reverse = 0;

            Console.WriteLine("Enter the Number to be reverse :");
            int number = Convert.ToInt32(Console.ReadLine());

            while (number > 0)
            {
                lastDigit = number % 10;
                reverse = reverse * 10 + lastDigit;
                number = number / 10;
            }
            Console.WriteLine("The Reverse Number is :" +reverse);
        }
    }
}