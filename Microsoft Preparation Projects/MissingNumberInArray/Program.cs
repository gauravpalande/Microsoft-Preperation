using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MissingNumberInArray
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

                int formulaSum = (arrayLength * (arrayLength + 1)) / 2;
                int arraySum = 0;

                for (int j = 0; j < arrayLength - 1; j++)
                {
                    arraySum += array[j];
                }

                Console.WriteLine(formulaSum - arraySum);
            }

            Console.ReadLine();
        }
    }
}
