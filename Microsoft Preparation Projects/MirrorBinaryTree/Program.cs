using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MirrorBinaryTree
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
                left = new Node(7) { right = new Node(11) },
                right = new Node(39)
            };

            ReverseTree(ten);
        }

        private static void ReverseTree(Node root)
        {
            if (root == null)
            {
                return;
            }

            Node temp = root.left;
            root.left = root.right;
            root.right = temp;

            ReverseTree(root.left);
            ReverseTree(root.right);
        }
    }
}
