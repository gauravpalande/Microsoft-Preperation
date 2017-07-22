using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuplicatesInAnArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split(null).Select(x => Convert.ToInt32(x)).ToArray();
            bool[] checkingArray = new bool[array.Length];

            for (int i = 0; i < array.Length; i++)
            {
                if (!checkingArray[Math.Abs(array[i])])
                {
                    checkingArray[Math.Abs(array[i])] = true;
                }
                else
                {
                    Console.WriteLine(array[i]);
                }
            }
            Console.ReadLine();
        }
    }
}
