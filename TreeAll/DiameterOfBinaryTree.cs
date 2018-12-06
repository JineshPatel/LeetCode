using System;
using System.Collections.Generic;
using System.Text;

namespace TreeAll
{
    /*
     Given a binary tree, you need to compute the length of the diameter of the tree. The diameter of a binary tree is the length of the longest path between any two nodes in a tree. This path may or may not pass through the root.

        Example:
        Given a binary tree 
                  1
                 / \
                2   3
               / \     
              4   5    
        Return 3, which is the length of the path [4,2,1,3] or [5,2,1,3].

        Note: The length of path between two nodes is represented by the number of edges between them.
         */
    public static class DiameterOfBinaryTree
    {
        public static int DiameterOfBinaryTree1(TreeNode root)
        {
            if (root==null)
            {
                return 0;
            }

            int ans = int.MinValue;

            int h = heightOfTree(root, ans);
            return ans;
        }

        private static int heightOfTree(TreeNode root, int ans)
        {

            if (root == null)
            {
                return 0;
            }
            int heightOfRightTree = heightOfTree(root.right, ans);
            int heightofLeftTree = heightOfTree(root.left, ans);

            ans = Math.Max(ans, heightOfRightTree + heightofLeftTree + 1);

            return 1 + Math.Max(heightofLeftTree, heightOfRightTree);
        }
    }
}
