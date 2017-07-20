using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KLargestOrSmallestElements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split(null).Select(x => Convert.ToInt32(x)).ToArray();

            Array.Sort(array);

            Console.WriteLine("How many elements do you want?");
            int noElements = Convert.ToInt32(Console.ReadLine());
            int[] outputArray = new int[noElements];

            Console.WriteLine("Enter 1 for largest or 2 for smallest?");
            int option = Convert.ToInt32(Console.ReadLine());

            switch (option)
            {
                case 1:
                    outputArray = array.Skip(array.Length-noElements).ToArray();
                    foreach (int element in outputArray)
                    {
                        Console.WriteLine(element);
                    }
                    break;

                case 2:
                    outputArray = array.Take(noElements).ToArray();
                    foreach (int element in outputArray)
                    {
                        Console.WriteLine(element);
                    }
                    break;

                default:
                    break;
            }
            Console.ReadLine();
        }
    }
}
