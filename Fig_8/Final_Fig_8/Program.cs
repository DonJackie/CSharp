using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Fig_8_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] array = new int[5];
            const int ArrayLength = 5;
            int[] array = new int[ArrayLength];

            for(int counter = 0; counter < array.Length; ++counter)
            {
                array[counter] = 2 + 2 * counter;
            }
            Console.WriteLine($"{"Index"}{"Value",8}");
            for(int counter=0; counter <array.Length; ++counter)
            {
                Console.WriteLine($"{counter,5}{array[counter],8}");//ArrayLength는 상수라 counter대신 사용될 수 없다.
            }
        }
    }
}
