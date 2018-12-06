using System;
using System.Collections;
using System.Collections.Generic;

namespace ValidParentheses
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(IsValid("]"));
        }

        public static bool IsValid(string s)
        {
            Stack<char> stack = new Stack<char>();
            foreach (var c in s)
            {
                if (c=='}' || c == ')'|| c == ']')
                {
                    if (stack.Count==0)
                    {
                        return false;
                    }
                    if (c == '}')
                    {
                        if (stack.Pop() != '{')
                        {
                            return false;
                        }
                    }
                    else if (c == ')')
                    {
                        if (stack.Pop() != '(')
                        {
                            return false;
                        }
                    }
                    else if (c == ']')
                    {
                        if (stack.Pop() != '[')
                        {
                            return false;
                        }
                    }                                       
                }
                else
                {
                    stack.Push(c);
                }
            }
            if (stack.Count>0)
            {
                return false;
            }
            return true;
        }
    }
}
