using System;
using System.Collections.Generic;
using System.Text;

namespace TreeAll
{
    /*
     * Given a binary tree, determine if it is a valid binary search tree (BST).

Assume a BST is defined as follows:

The left subtree of a node contains only nodes with keys less than the node's key.
The right subtree of a node contains only nodes with keys greater than the node's key.
Both the left and right subtrees must also be binary search trees.
Example 1:

Input:
    2
   / \
  1   3
Output: true
Example 2:

    5
   / \
  1   4
     / \
    3   6
Output: false
Explanation: The input is: [5,1,4,null,null,3,6]. The root node's value
             is 5 but its right child's value is 4.
    */
    public static class IsBinarySearchTree
    {
        public static bool IsValidBST(TreeNode root)
        {
            return isBSTUtil(root, int.MinValue, int.MaxValue);
        }

        private static bool isBSTUtil(TreeNode root, int minValue, int maxValue)
        {
            if (root==null)
            {
                return true ;
            }

            return root.val > minValue &&
                   root.val < maxValue &&
                   isBSTUtil(root.right, minValue, root.val) &&
                   isBSTUtil(root.left, root.val, maxValue);


        }
    }
}
