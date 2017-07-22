using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchinaRotatedArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int noOfTestCases = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < noOfTestCases; i++)
            {
                int arrayLength = Convert.ToInt32(Console.ReadLine());
                int[] array = Console.ReadLine().Split(null).Select(x => Convert.ToInt32(x)).ToArray();
                int numberToBeFound = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine(Array.IndexOf(array, numberToBeFound));
            }

            Console.ReadLine();
        }
    }
}
