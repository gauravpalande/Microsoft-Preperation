using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindMaximum6
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split(null).Select(x => Convert.ToInt32(x)).ToArray();
            int[] maximum = new int[6];

            for (int i = 0; i < maximum.Length; i++)
            {
                maximum[i] = int.MinValue;
            }

            for (int j = 0; j < array.Length; j++)
            {
                int minimum = maximum.Min();
                if (array[j] > minimum)
                {
                    maximum[Array.IndexOf(maximum, minimum)] = array[j];
                }
            }

            for (int k = 0; k < maximum.Length; k++)
            {
                Console.WriteLine(maximum[k]);
            }

            Console.ReadLine();
        }
    }
}
