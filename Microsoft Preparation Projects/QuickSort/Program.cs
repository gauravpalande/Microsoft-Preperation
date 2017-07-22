using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split(null).Select(x => Convert.ToInt32(x)).ToArray();
            
            QuickSort(array, 0, array.Length - 1);

            Console.ReadLine();
        }

        private static void QuickSort(int[] array, int v1, int v2)
        {

            if (v1 < v2)
            {
                int pos = Partition(array, v1, v2);
                QuickSort(array, v1, pos - 1);
                QuickSort(array, pos + 1, v2);
            }
        }

        private static int Partition(int[] array, int v1, int v2)
        {
            int pivot = array[v2];
            Console.WriteLine(pivot);
            int small = v1 - 1;

            for (int k = v1; k < v2; k++)
            {
                if (array[k] <= pivot)
                {
                    small++;
                    Swap(array, k, small);
                }
            }

            Swap(array, v2, small + 1);
            Console.WriteLine(String.Join(" ", array));
            return small + 1;
        }

        private static void Swap(int[] array, int k, int small)
        {
            int temp = array[k];
            array[k] = array[small];
            array[small] = temp;
        }
    }
}
