using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _012Sort
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList<int> input = new LinkedList<int>(new int[] { 2, 0, 1, 0, 1, 0, 2 });
            Dictionary<int, int> sorter = new Dictionary<int, int>();

            foreach (int item in input)
            {
                if (sorter.ContainsKey(item))
                {
                    sorter[item]++;
                }
                else
                {
                    sorter.Add(item, 1);
                }
            }

            List<int> keys = sorter.Keys.ToList();
            keys.Sort();

            LinkedList<int> output = new LinkedList<int>();

            foreach (int key in keys)
            {
                for (int i = 0; i < sorter[key]; i++)
                {
                    output.AddLast(key);
                    Console.WriteLine(key);
                }
            }

            Console.ReadLine();
        }
    }
}
