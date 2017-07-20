using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Key_Pair
{
    class Program
    {
        static void Main(string[] args)
        {
            int noTestCases = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < noTestCases; i++)
            {
                string[] parameters = Console.ReadLine().Split(null);
                int givenSum = Convert.ToInt32(parameters[1]);
                int[] array = Console.ReadLine().Split(null).Select(x => Convert.ToInt32(x)).ToArray();
                string output = "No";

                foreach (int element in array)
                {
                    int difference = givenSum - element;
                    if (Array.IndexOf(array, difference) != -1)
                    {
                        output = "Yes";
                        break;
                    }
                }
                Console.WriteLine(output);
            }
            Console.ReadLine();
        }
    }
}
