using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoveEveryKthNode
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

            LinkedListNode<int> node = list.First;
            int k = 2;

            for (int i = 1; i <= list.Count; i++)
            {
                if (node != null)
                {
                    LinkedListNode<int> nextNode = node.Next;
                    if (i % k == 0)
                    {
                        list.Remove(node);
                    }
                    node = nextNode;
                }
            }

            do
            {
                Console.WriteLine(list.First.Value);
                list.RemoveFirst();
            } while (list.Count > 0);

            Console.ReadLine();
        }
    }
}
