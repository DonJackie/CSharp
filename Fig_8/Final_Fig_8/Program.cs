﻿using System;
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
            int[] array = { 87, 68, 94, 100, 83, 78, 85, 91, 76, 87 };
            int total = 0;

            foreach( int number in array)
            {
                total += number;
            }
            Console.WriteLine($"Total of array elements: {total}");
        }
    }
}
