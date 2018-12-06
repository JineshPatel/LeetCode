using System;

namespace TreeAll
{
    class Program
    {
        static void Main(string[] args)
        {
            TreeNode a1 = new TreeNode(1);
            TreeNode a2 = new TreeNode(2);
            TreeNode a3 = new TreeNode(3);
            TreeNode a4 = new TreeNode(4);
            TreeNode a5 = new TreeNode(5);
            TreeNode b1 = new TreeNode(1);
            TreeNode b2 = new TreeNode(2);
            TreeNode b3 = new TreeNode(3);
            TreeNode b4 = new TreeNode(4);

            a1.left = a2;
            a1.right = a3;
            a2.left = a4;
            a2.right = a5;


         //   var ans = BinarySearchTreeToDublyLinkedList.TreeToDoublyList(a1);

            int[] pre = new int[] { 1, 2, 4, 5, 3, 7, 6, 8 };
            int[] inOrder = new int[] { 4, 2, 5, 1, 6, 7, 3, 8 };

          //  var t = BinaryTreeFromPreOrderAndInroderTraversal.BuildTree(pre, inOrder);

            char[,] grid = new char[,]
            {
                { '1', '1', '1','1', '0' },
                { '1', '1', '0','1', '0' },
                { '1', '1', '0','0', '0' },
                { '0', '0', '0','0', '0' }
            };
            Console.WriteLine(  NumberOfIslands.NumIslands(grid));
            Console.ReadKey();
        }
    }
}
