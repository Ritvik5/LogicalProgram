using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgram
{
    public class FibonacciSeries
    {
        public static void GetSeries()
        {
            int Prevoiustoprevious = 0;
            int Previous = 1;
            int next;

            Console.WriteLine("Please enter the Number to get FibonacciSeries");
            int input = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Fibonacci Series of " + input + " is :");
            for (int i = 0; i < input; i++)
            {
                next = Prevoiustoprevious + Previous;
                Prevoiustoprevious = Previous;
                Previous = next;

                Console.WriteLine(next);
            }
        }
    }
}
