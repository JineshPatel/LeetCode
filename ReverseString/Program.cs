using System;
using System.Collections;
using System.Text;

namespace ReverseString
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ReverseString("Hello World!"));
            Console.ReadKey();
        }
        public static string ReverseString(string s)
        {
            Stack stack = new Stack();
            foreach (var c in s)
            {
                stack.Push(c);
            }
            StringBuilder sb = new StringBuilder();
            while (stack.Count>0)
            {
                sb.Append(stack.Pop());
            }
            return sb.ToString();
        }

        public static void ReverseWords(char[] str)
        {

        }
    }
}
