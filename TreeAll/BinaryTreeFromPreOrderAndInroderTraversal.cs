using System;
using System.Collections.Generic;
using System.Text;

namespace TreeAll
{
    /*Given preorder and inorder traversal of a tree, construct the binary tree.

        Note:
        You may assume that duplicates do not exist in the tree.

        For example, given

        preorder = [3,9,20,15,7]
        inorder = [9,3,15,20,7]
        Return the following binary tree:

            3
           / \
          9  20
            /  \
           15   7
           
     */
    public static class BinaryTreeFromPreOrderAndInroderTraversal
    {

        public static TreeNode BuildTree(int[] preorder, int[] inorder)
        {
            int preStart = 0;
            int preEnd = preorder.Length - 1;
            int inStart = 0;
            int inEnd = inorder.Length - 1;

            TreeNode treeNode = ConstructTree(preorder, preStart, preEnd, inorder, inStart, inEnd);

            return treeNode;
                

            
              
        }

        private static TreeNode ConstructTree(int[] preorder, int preStart, int preEnd, int[] inorder, int inStart, int inEnd)
        {
            if (preStart>preEnd || inStart>inEnd)
            {
                return null;
            }
            int val = preorder[preStart];
            TreeNode root = new TreeNode(val);

            int k = 0;
            for (int i = 0; i < inorder.Length; i++)
            {
                if (val==inorder[i])
                {
                    k = i;
                    break;
                }
            }

            root.left = ConstructTree(preorder, preStart + 1, preStart + (k - inStart), inorder, inStart, k - 1);
            root.right = ConstructTree(preorder, preStart + (k - inStart) + 1, preEnd, inorder, k + 1, inEnd);

            return root;
        }
    }
}
