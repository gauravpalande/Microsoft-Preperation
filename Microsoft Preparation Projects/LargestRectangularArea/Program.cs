using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LargestRectangularArea
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split(null).Select(x => Convert.ToInt32(x)).ToArray();
            int maxArea = int.MinValue;

            for (int i = 0; i < array.Length; i++)
            {
                int j = i, k = i + 1, area = 0;
                while (j >= 0)
                {
                    if (array[j] >= array[i])
                    {
                        area += array[i];
                    }
                    else
                    {
                        break;
                    }
                    j--;
                }
                while (k < array.Length)
                {
                    if (array[k] >= array[i])
                    {
                        area += array[i];
                    }
                    else
                    {
                        break;
                    }
                    k++;
                }
                maxArea = area > maxArea ? area : maxArea;
            }

            Console.WriteLine(maxArea);
            Console.ReadLine();
        }
    }
}
