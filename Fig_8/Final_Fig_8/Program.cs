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
            int[] responses = { 1, 2, 5, 14, 3, 5, 2, 1, 3, 3, 1, 4, 3, 3, 3, 2, 3, 3, 2, 14 };
            
            var frequency = new int[6];

            for (var answer = 0; answer < responses.Length; ++answer)
            {
                try
                {
                    ++frequency[responses[answer]];
                }
                catch (IndexOutOfRangeException ex) // If it's over 6  frequency value를 over하면 예외가 뜸
                {
                    Console.WriteLine(ex.Message);
                    Console.WriteLine(
                        $" responses[{answer}] = {responses[answer]}\n");
                }
            }
        }
    }
}
