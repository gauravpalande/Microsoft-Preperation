using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartialSorts
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split(null).Select(x => Convert.ToInt32(x)).ToArray();

            int[] evenArray = array.Where(x => x % 2 == 0).ToArray();
            int[] oddArray = array.Where(x => x % 2 == 1).ToArray();

            QuickSort(evenArray, 0, evenArray.Length - 1);
            QuickSort(oddArray, 0, oddArray.Length - 1);

            oddArray = oddArray.Reverse().ToArray();

            int[] output = new int[evenArray.Length + oddArray.Length];
            for (int i = 0; i < oddArray.Length; i++)
            {
                output[i] = oddArray[i];
            }

            for (int i = 0; i < evenArray.Length; i++)
            {
                output[oddArray.Length + i] = evenArray[i];
            }

            Console.WriteLine(String.Join(" ", output));
            Console.ReadLine();
        }

        private static void QuickSort(int[] givenArray, int v1, int v2)
        {
            if (v1 < v2)
            {
                int pos = Partition(givenArray, v1, v2);
                QuickSort(givenArray, v1, pos - 1);
                QuickSort(givenArray, pos + 1, v2);
            }
        }

        private static int Partition(int[] givenArray, int v1, int v2)
        {
            int pivot = givenArray[v2];
            int small = v1 - 1;

            for (int k = v1; k < v2; k++)
            {
                if (givenArray[k] <= pivot)
                {
                    small++;
                    Swap(givenArray, k, small);
                }
            }

            Swap(givenArray, small + 1, v2);
            return small + 1;
        }

        private static void Swap(int[] givenArray, int k, int small)
        {
            int temp = givenArray[k];
            givenArray[k] = givenArray[small];
            givenArray[small] = temp;
        }
    }
}
