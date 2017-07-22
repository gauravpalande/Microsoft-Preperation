using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3Factors
{
    class Program
    {
        static void Main(string[] args)
        {
            int m = Convert.ToInt32(Console.ReadLine());
            int[] arr = Console.ReadLine().Split(null).Select(x => Convert.ToInt32(x)).ToArray();
            int FactorsCount = 0;

            List<int> factorsOfM = new List<int>();
            int sqrt = Convert.ToInt32(Math.Ceiling(Math.Sqrt(m)));

            for (int i = 1; i <= sqrt; i++)
            {
                if (m % i == 0)
                {
                    factorsOfM.Add(i);
                    factorsOfM.Add(m / i);
                }
            }

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < 1 || arr[i] > m || !factorsOfM.Contains(arr[i]))
                {
                    arr[i] = 0;
                }
            }

            int[] finalArr = arr.Where(x => x > 0).ToArray();

            for (int i = 0; i < finalArr.Length; i++)
            {
                int productOfTwo = m / finalArr[i];
                for (int j = i + 1; j < finalArr.Length; j++)
                {
                    if (productOfTwo % finalArr[j] == 0)
                    {
                        int lastFactor = productOfTwo / finalArr[j];
                        for (int k = j + 1; k < finalArr.Length; k++)
                        {
                            if (lastFactor == finalArr[k])
                            {
                                FactorsCount++;
                            }
                        }
                    }
                }
            }

            Console.WriteLine(FactorsCount);
            Console.ReadLine();
        }
    }
}
