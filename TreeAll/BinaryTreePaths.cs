using System;
using System.Collections.Generic;
using System.Text;

namespace TreeAll
{/*
    Given a binary tree, return all root-to-leaf paths.

Note: A leaf is a node with no children.

Example:

Input:

   1
 /   \
2     3
 \
  5

Output: ["1->2->5", "1->3"]

Explanation: All root-to-leaf paths are: 1->2->5, 1->3
     */
    public static class BinaryTreePaths
    {

        public static IList<string> BinaryTreePath(TreeNode root)
        {
            List<string> list = new List<string>();
            BTPUtil(root, list, "");
            return list.ToArray();
        }

        private static void BTPUtil(TreeNode root, List<string> list, string path)
        {


            if (root == null)
            {
                return;
            }

            path += root.val;
            if (root.left == null && root.right == null)
            {
                list.Add(path);
                return;
            }
            path += "->";
            BTPUtil(root.left, list, path);
            BTPUtil(root.right, list, path);
        }
    }
}
