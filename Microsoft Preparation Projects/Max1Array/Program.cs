using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Max1Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] array = { { 0, 1, 1, 1 }, { 0, 0, 1, 1 }, { 1, 1, 1, 1 }, { 0, 0, 0, 0 } };

            int columns = array.GetLength(0);
            int rows = array.GetLength(1);
            int longestRow = int.MinValue;

            for (int i = 0; i < columns; i++)
            {
                if (longestRow == int.MinValue)
                {
                    for (int j = 0; j < rows; j++)
                    {
                        if (array[j, i] == 1)
                        {
                            if (longestRow == int.MinValue)
                            {
                                longestRow = j;
                            }
                        }
                    }
                }
                else
                {
                    break;
                }
            }

            if (longestRow > int.MinValue)
            {
                string row = "";
                for (int i = 0; i < columns; i++)
                {
                    row = row + " " + array[longestRow, i];
                }
                Console.WriteLine(row);
            }

            Console.ReadLine();
        }
    }
}
