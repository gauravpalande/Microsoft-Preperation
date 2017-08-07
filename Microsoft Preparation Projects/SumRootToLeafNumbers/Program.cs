using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumRootToLeafNumbers
{

    //Definition for a binary tree node.
    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int x) { val = x; }
    }
    public class Solution
    {
        Stack<TreeNode> treeStack = new Stack<TreeNode>();

        public int SumNumbers(TreeNode root)
        {
            int sum = 0;
            treeStack.Push(root);

            if (root == null)
            {
                return sum;
            }
            if (root.left == null && root.right == null)
            {
                string sumInString = "";
                foreach (TreeNode node in treeStack)
                {
                    sumInString += node.val.ToString();
                }
                char[] charArr = sumInString.ToCharArray();
                Array.Reverse(charArr);
                sumInString = new string(charArr);
                treeStack.Pop();
                return Convert.ToInt32(sumInString);
            }
            if (root.left != null)
            {
                sum += SumNumbers(root.left);
            }
            if (root.right != null)
            {
                sum += SumNumbers(root.right);
            }
            treeStack.Pop();
            return sum;
        }
    }
}
