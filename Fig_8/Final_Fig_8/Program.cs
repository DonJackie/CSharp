using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Fig_8
{
    class Program
    {
        static void Main(string[] args)
        {
            var randomNumbers = new Random();
            var frequency = new int[7];
            var total=0;

            for (var roll = 1; roll <=60000000; ++roll)
            {
                ++frequency[randomNumbers.Next(1, 7)];
            }
            Console.WriteLine($"{"Face"}{"Frequency",10}");
            for(var face = 1; face<frequency.Length; ++face)
            {
                Console.WriteLine($"{face,4}{frequency[face],10}");
                total += frequency[face];
            }
            Console.WriteLine($"total result = {total}");
        }
    }
}
