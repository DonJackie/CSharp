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
            int[] array = { 1, 2, 3, 4, 5 };

            Console.WriteLine("Effects of passing reference to entire array:");
            Console.WriteLine("The values of the original array are:");

            foreach( var value in array)
            {
                Console.Write($"    {value}");
            }
            ModifyArray(array);
            Console.WriteLine("\n\nThe values of the modified array are:");
            foreach(var value in array)
            {
                Console.Write($"    {value}");
            }
        }

        static void ModifyArray(int[] array2)
        {
            for (var counter = 0; counter < array2.Length; ++counter)
            {
                array2[counter] *= 2;
            }
        }
    }
}
