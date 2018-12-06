using System;

namespace LinkedListAll
{
    class Program
    {
        static void Main(string[] args)
        {
            ListNode a1 = new ListNode(1);
           
            ListNode a2 = new ListNode(2);
            ListNode a3 = new ListNode(3);
            ListNode a4 = new ListNode(4);
            ListNode a5 = new ListNode(5);

            a1.next = a2;
            a2.next = a3;
            a3.next = a4;
            a4.next = a5;
            a5.next = null;
            ListNode b1 = new ListNode(1);
            ListNode b2 = new ListNode(2);

            b1.next = b2;
            b2.next = a4;

           

            ListNode c1 = new ListNode(1);

            TreeNode t1 = new TreeNode(1);
            TreeNode t2 = new TreeNode(2);
            TreeNode t3 = new TreeNode(3);
            TreeNode t4 = new TreeNode(4);
            TreeNode t5 = new TreeNode(5);
            TreeNode t6 = new TreeNode(6);

            t1.left = t2;
            t1.right = t5;
            t2.left = t3;
            t2.right = t4;
            t5.right = t6;

            FlatTreeNodeToLinkedList flat = new FlatTreeNodeToLinkedList();
            flat.Flatten(t1);

            Console.ReadKey();

        }
    }
}
