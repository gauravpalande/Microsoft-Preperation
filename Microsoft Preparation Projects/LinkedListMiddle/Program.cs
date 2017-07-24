using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListMiddle
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList<int> list = new LinkedList<int>();
            list.AddFirst(new LinkedListNode<int>(1));
            list.AddLast(new LinkedListNode<int>(2));
            list.AddLast(new LinkedListNode<int>(3));
            list.AddLast(new LinkedListNode<int>(4));
            list.AddLast(new LinkedListNode<int>(5));

            int listLength = list.Count;
            LinkedListNode<int> foreRunner = list.First;
            LinkedListNode<int> runner = list.First;


            for (int i = 0; i < listLength; i++)
            {
                if (i % 2 == 1)
                {
                    runner = runner.Next;
                }
                foreRunner = foreRunner.Next;
            }

            Console.WriteLine(runner.Value);
            Console.ReadLine();
        }
    }
}
