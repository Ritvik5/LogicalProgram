using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgram
{
    public class PerfectNumber
    {
        public static void IsPerfect()
        {
            Console.WriteLine("Enter The number to Check");
            int input = Convert.ToInt32(Console.ReadLine());

            int accumulator = 0;
            for (int i = 1; i < input; i++)
            {
                if (input % i == 0)
                {
                    accumulator += i;
                }

            }
            if (accumulator == input)
            {
                Console.WriteLine("The Number " + input + " is Perfect");
            }
            else
            {
                Console.WriteLine("The Number " + input + " is not Perfect");
            }
        }
    }
}
