using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckForBST
{
    class Node
    {
        public int data;
        public Node left, right;

        public Node(int value)
        {
            data = value;
            left = right = null;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Node ten = new Node(10)
            {
                left = new Node(7) { right = new Node(11) }, right = new Node(39)
            };

            Node eleven = new Node(11)
            {
                left = new Node(7) { right = new Node(10) },
                right = new Node(39)
            };

            Stack<int> treeStack = new Stack<int>();

            InOrder(ten, treeStack);

            int previous = int.MinValue, current;
            bool bst = true;

            do
            {
                current = treeStack.Pop();
                if (current < previous)
                {
                    bst = false;
                    return;
                }
            } while (treeStack.Count > 0);
            Console.WriteLine(bst ? 1 : 0);

            InOrder(eleven, treeStack);

            bst = true;
            previous = int.MinValue;

            do
            {
                current = treeStack.Pop();
                if (current < previous)
                {
                    bst = false;
                    return;
                }
            } while (treeStack.Count > 0);
            Console.WriteLine(bst ? 1 : 0);

            Console.ReadLine();
        }

        private static void InOrder(Node node, Stack<int> stack)
        {
            if (node.left != null)
            {
                InOrder(node.left, stack);
            }

            stack.Push(node.data);

            if (node.right != null)
            {
                InOrder(node.right, stack);
            }
        }
    }
}
