using System;
using System.Collections.Generic;
using System.Text;

namespace TreeAll
{
    public static class SameTree
    {/*
        Given two binary trees, write a function to check if they are the same or not.

Two binary trees are considered the same if they are structurally identical and the nodes have the same value.

Example 1:

Input:     1         1
          / \       / \
         2   3     2   3

        [1,2,3],   [1,2,3]

Output: true
Example 2:

Input:     1         1
          /           \
         2             2

        [1,2],     [1,null,2]

Output: false
Example 3:

Input:     1         1
          / \       / \
         2   1     1   2

        [1,2,1],   [1,1,2]

Output: false*/
        public static bool IsSameTree(TreeNode p, TreeNode q)
        {
            //bool result=true;
            Stack<TreeNode> stack_p = new Stack<TreeNode>();
            Stack<TreeNode> stack_q = new Stack<TreeNode>();
            if (p != null) stack_p.Push(p);
            if (q != null) stack_q.Push(q);
            while (stack_p.Count!=0 && stack_q.Count!=0)
            {
                TreeNode pn = stack_p.Pop();
                TreeNode qn = stack_q.Pop();
                if (pn.val != qn.val) return false;
                if (pn.right != null) stack_p.Push(pn.right);
                if (qn.right != null) stack_q.Push(qn.right);
                if (stack_p.Count != stack_q.Count) return false;
                if (pn.left != null) stack_p.Push(pn.left);
                if (qn.left != null) stack_q.Push(qn.left);
                if (stack_p.Count != stack_q.Count) return false;
            }
            return stack_p.Count == stack_q.Count;
        }
    }
}
