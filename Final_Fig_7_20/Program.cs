using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Fig_7_20
{
    class Program
    {
        static void Main(string[] args)
        {
            int y = 5;
            int z;

            Console.WriteLine($"Original value of y : {y}"); //5
            Console.WriteLine("Original value of x : uninitialized\n");//nothing

            SquareRef(ref y);
            SquareOut(out z);

            Console.WriteLine($"Value of y after SquareRef: {y}"); //25
            Console.WriteLine($"value of z after SquareOut: {z}\n"); //x

            y = 5;
            z=3;

            Square(y);
            Square(z);

            Console.WriteLine($"Value of y after SquareRef: {y}"); //25
            Console.WriteLine($"value of z after SquareOut: {z}\n"); //x

        }

        static void SquareRef(ref int x)
        {
            x = x * x;
        }

        static void SquareOut(out int x)
        {
            x = 6;
            x = x * x;
        }

        static void Square(int x)
        {
            x = x * x;
        }
    }
}
