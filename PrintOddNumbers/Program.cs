using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintOddNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int OddCount = 0;
            Console.WriteLine("50 to 80 Odd Number:");
            for (int i = 50; i <= 80; i++)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine(i);
                    OddCount++;
                }
            }
            Console.WriteLine("Total Odd Number Count=" + OddCount);
            {
                Console.ReadLine();
            }
        }
    }
}
