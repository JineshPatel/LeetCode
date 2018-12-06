using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedListAll
{
    /*
     Flatten Binary Tree to Linked List
   Given a binary tree, flatten it to a linked list in-place.

For example, given the following tree:

    1
   / \
  2   5
 / \   \
3   4   6
The flattened tree should look like:

1
 \
  2
   \
    3
     \
      4
       \
        5
         \
          6*/
   public class FlatTreeNodeToLinkedList
    {
        public void Flatten(TreeNode root)
        {

            if (root == null || root.left == null && root.right == null)
            {
                return;
            }

            if (root.left != null)
            {
                Flatten(root.left);
                TreeNode tmpRight = root.right;
                root.right = root.left;
                root.left = null;
                TreeNode t = root.right;
                while (t.right != null)
                {
                    t = t.right;
                }
                t.right = tmpRight;
            }
            Flatten(root.right);

            //Stack<TreeNode> stack = new Stack<TreeNode>();
            //TreeNode p = root;

            //while (p != null || stack.Count!=0)
            //{

            //    if (p.right != null)
            //    {
            //        stack.Push(p.right);
            //    }

            //    if (p.left != null)
            //    {
            //        p.right = p.left;
            //        p.left = null;
            //    }
            //    else if (stack.Count!=0)
            //    {
            //        TreeNode temp = stack.Pop();
            //        p.right = temp;
            //    }

            //    p = p.right;
            //}
        }

        
    }
}
