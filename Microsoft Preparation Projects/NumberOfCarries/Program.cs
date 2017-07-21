using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberOfCarries
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = Console.ReadLine().ToCharArray().Select(x => Convert.ToInt32(x) - 48).ToArray();
            arr1 = arr1.Reverse().ToArray();
            int[] arr2 = Console.ReadLine().ToCharArray().Select(x => Convert.ToInt32(x) - 48).ToArray();
            arr2 = arr2.Reverse().ToArray();

            int iterationLength = arr1.Length < arr2.Length ? arr1.Length : arr2.Length;
            int carryValue = 0, carryCount = 0;

            for (int i = 0; i < iterationLength; i++)
            {
                int digitSum = arr1[i] + arr2[i] + carryValue;
                carryValue = digitSum / 10;
                if (carryValue > 0)
                {
                    carryCount++;
                }
            }

            Console.WriteLine(carryCount);
            Console.ReadLine();
        }
    }
}
