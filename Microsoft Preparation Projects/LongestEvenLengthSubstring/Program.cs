using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LongestEvenLengthSubstring
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().ToCharArray().Select(x => Convert.ToInt32(x) - 48).ToArray();
            int arrayLength = array.Length;
            //int start = 0, mid = 0, end = 1;
            Tuple<int, int, int> max = new Tuple<int, int, int>(-1, -1, int.MinValue);

            for (int start = 0; start < array.Length - 1; start++)
            {
                int end = start + 1;
                for (int mid = start; mid <= start + end / 2; mid++)
                {
                    int sumStartMid = 0;
                    for (int i = start; i <= mid; i++)
                    {
                        sumStartMid += array[i];
                    }
                    int sumMidEnd = 0;
                    for (int i = mid + 1; i <= end; i++)
                    {
                        sumMidEnd += array[i];
                    }

                    if (sumStartMid == sumMidEnd && sumStartMid > max.Item3)
                    {
                        max = new Tuple<int, int, int>(start, end, sumStartMid);
                    }

                    end += 2;
                    if (end >= array.Length)
                    {
                        break;
                    }
                }
            }

            if (max.Item1 == 0 && max.Item2 == array.Length-1)
            {
                Console.WriteLine("The complete string is of even length and sum of first and second half digits is same");
            }
            else
            {
                string output = "";
                for (int i = max.Item1; i <= max.Item2; i++)
                {
                    output += array[i].ToString();
                }

                Console.WriteLine("The longest substring with same first and second half sum is \"" + output + "\"");
            }

            Console.ReadLine();
        }
    }
}
