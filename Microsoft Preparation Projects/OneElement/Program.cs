using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneElement
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 12, 1, 12, 3, 12, 1, 1, 2, 3, 3 };
            int ones = 0, twos = 0;
            int commonMask;

            for (int i = 0; i < arr.Length; i++)
            {
                twos = twos | (ones & arr[i]);
                ones = ones ^ arr[i];

                commonMask = ~(ones & twos);

                ones &= commonMask;
                twos &= commonMask;
            }
            Console.WriteLine(ones);
            Console.ReadLine();
        }
    }
}
