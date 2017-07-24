using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RootToLeafPathSum
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
            Node one = new Node(1)
            {
                left = new Node(2),
                right = new Node(3)
            };

            bool output = hasPathSum(one, 4);

            Console.WriteLine(output ? 1 : 0);
            Console.ReadLine();
        }

        private static bool hasPathSum(Node one, int v)
        {
            if (one == null)
            {
                return false;
            }
            else
            {
                v -= one.data;
            }

            if (v == 0 && one.left == null && one.right == null)
            {
                return true;
            }

            if (v < 0)
            {
                return false;
            }

            return hasPathSum(one.left, v) || hasPathSum(one.right, v);
        }
    }
}
