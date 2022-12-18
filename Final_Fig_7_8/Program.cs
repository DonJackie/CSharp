using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Fig_7_8
{
    class Program
    {
        private enum Color : byte { RED, GREEN, BLUE}
        static void Main(string[] args)
        {
            Color myColor1 = Color.RED;
            Color myColor2 = (Color)2;

            Console.WriteLine(myColor1);
            Console.WriteLine(myColor2);

        }
    }
}
