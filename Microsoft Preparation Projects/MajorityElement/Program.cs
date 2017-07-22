using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MajorityElement
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

                int majorityElement = array.GroupBy(x => x).OrderByDescending(y => y.Count()).First().Key;
                int majorityElementCount = array.GroupBy(x => x).OrderByDescending(y => y.Count()).First().Count();

                if (majorityElementCount > arrayLength / 2)
                {
                    Console.WriteLine(majorityElement);
                }
                else
                {
                    Console.WriteLine("NO Majority Element");
                }
            }

            Console.ReadLine();
        }
    }
}
