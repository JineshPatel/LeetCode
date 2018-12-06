using System;
using System.Collections.Generic;
using System.Text;

namespace BackTracking
{
    static class RemoveInvalidParanthesis
    {


        public static IList<string> RemoveInvalidParentheses(string s)
        {

            Stack<char> stack = new Stack<char>();
            List<char> extras = new List<Char>();
            List<string> result = new List<string>();
            bool IsChar=false;
            //Loop throught all the char in s
            if (s.Length == 0)
            {
                result.Add("");
                return result;
            }
            if (s.Length == 1)
            {
                if (s[0] == '(' || s[0] == ')')
                {
                    result.Add("");
                    return result;
                }
                else
                {
                    result.Add(s);
                    return result;
                }
            }
            foreach (Char c in s)
            {
                if (c == '(')
                { stack.Push(c); }
                else if (c == ')')
                {
                    if (stack.Count > 0)
                    {
                        char r = stack.Pop();
                        if (r == '(')
                        {
                            continue;
                        }
                        else
                        {
                            extras.Add(r);
                        }
                    }
                    else
                    {
                        extras.Add(c);
                    }

                }
                else
                {
                    IsChar = true;
                }
            }
            if (stack.Count>0)
            {
                while (stack.Count!=0)
                {
                    extras.Add(stack.Pop());
                }
            }
            result.Add("");
            foreach (char extraChar in extras)
            {
                for (int i = 0; i < s.Length; i++)
                {
                    if (extraChar == s[i])
                    {
                        var r = s.Remove(i, 1);

                        if (!result.Contains(r) && IsvalidParenthesis(r))
                        {
                            result.Remove("");
                            result.Add(r);
                        }
                    }
                }
            }

            if (IsChar && result[0] == "")
            {
                if (IsvalidParenthesis(s))
                {
                    result.Remove("");
                    result.Add(s);
                }
                else
                {


                    result.Remove("");
                    string r = s.Replace("(", "");
                    r = r.Replace(")", "");
                    result.Add(r);
                }
            }
            if (IsvalidParenthesis(s))
            {
                result.Remove("");
                result.Add(s);
            }
            return result;
        }


      public static  IList<string> removeInvalidParenthesisBFS(string str)
        {
            List<string> result = new List<string>();

            if (str.Length == 0)
            {
                result.Add("");
                return result;
            }

            //  visit set to ignore already visited string 
            HashSet<string> visit = new HashSet<string>();

            //  queue to maintain BFS 
            Queue<string> q = new Queue<string>();
            string temp;
            bool level=false;

            //  pushing given string as starting node into queue 
            q.Enqueue(str);
            visit.Add(str);
            while (q.Count!=0)
            {
                str = q.Dequeue();
                if (IsvalidParenthesis(str))
                {
                    // cout << str << endl;

                    // If answer is found, make level true 
                    // so that valid string of only that level 
                    // are processed.
                    result.Add(str);
                    level = true;
                }
                if (level)
                    continue;
                for (int i = 0; i < str.Length; i++)
                {
                    if (str[i]!='(' && str[i]!=')')
                        continue;

                    // Removing parenthesis from str and 
                    // pushing into queue,if not visited already 
                    temp = str.Substring(0, i) + str.Substring(i + 1);
                    if (!visit.Contains(temp))
                    {
                        q.Enqueue(temp);
                        visit.Add(temp);
                    }
                }
            }
            return result;
        }

        private static bool isParenthesis(char v)
        {
            return v == '(' || v == ')';
        }

        private static bool IsvalidParenthesis(string s)
        {
            Stack<char> stack = new Stack<char>();
            foreach (Char c in s)
            {
                if (c == '(')
                { stack.Push(c); }
                else if (c == ')')
                {
                    if (stack.Count > 0)
                    {
                        char r = stack.Pop();
                        if (r == '(')
                        {
                            continue;
                        }
                        else
                        {
                            return false;
                        }
                    }
                    else
                    {
                        return false;
                    }

                }
            }
            if (stack.Count > 0)
            {
                return false;
            }
            return true;
        }
    }
}
