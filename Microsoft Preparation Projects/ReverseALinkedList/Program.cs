using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseALinkedList
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

            Stack<LinkedListNode<int>> listStack = new Stack<LinkedListNode<int>>();
            do
            {
                listStack.Push(list.First);
                list.RemoveFirst();
            } while (list.Count > 0);

            do
            {
                list.AddLast(listStack.Pop());
            } while (listStack.Count > 0);

            do
            {
                Console.WriteLine(list.First.Value);
                list.RemoveFirst();
            } while (list.Count > 0);

            Console.ReadLine();
        }
    }
}
