using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Fig_7_17
{
    class Program
    {
        static void Main(string[] args)
        {
            for (long counter = 0; counter <= 10; ++counter)
            {
                Console.WriteLine($"{counter}! = {Factorial(counter)}");
            }
        }
        static long Factorial(long a)
        {
            long result = 0;
            if (a == 0 || a == 1)
                return 1;
            else result = a*Factorial(a-1);
            return result;
        }
    }
}
