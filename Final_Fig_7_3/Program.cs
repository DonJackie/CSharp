using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Fig_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter first floating-point value : ");
            double number1 = double.Parse(Console.ReadLine());

            Console.Write("Enter second floating-point value : ");
            double number2 = double.Parse(Console.ReadLine());

            Console.Write("Enter third floating-point value : ");
            double number3 = double.Parse(Console.ReadLine());

            double result = Maximum(number1, number2, number3);

            Console.WriteLine("Maximum is : " + result);
        }

        static double Maximum(double n1, double n2, double n3)
        {
            double result=0;
            if (n1 > n2) result = n1;
            else result = n2;

            if (n3 > result) result = n3;
            return result;
        }

    }
}
