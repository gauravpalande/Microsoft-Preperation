using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kadane_s_Algorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            int noTestCases = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < noTestCases; i++)
            {
                int arrayLength = Convert.ToInt32(Console.ReadLine());
                int[] array = Console.ReadLine().Split(null).Select(x => Convert.ToInt32(x)).ToArray();
                int finalSum = int.MinValue;
                int tempSum = 0;

                for (int j = 0; j < arrayLength; j++)
                {
                    tempSum += array[j];

                    if (tempSum > finalSum)
                    {
                        finalSum = tempSum;
                    }
                    else
                    {
                        tempSum = 0;
                    }
                }
                Console.WriteLine(finalSum);
            }
            Console.ReadLine();
        }
    }
}
