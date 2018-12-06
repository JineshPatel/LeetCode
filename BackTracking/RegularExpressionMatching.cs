using System;
using System.Collections.Generic;
using System.Text;

namespace BackTracking
{
    /*
     * Given an input string (s) and a pattern (p), implement regular expression matching with support for '.' and '*'.

        '.' Matches any single character.
        '*' Matches zero or more of the preceding element.
        The matching should cover the entire input string (not partial).

        Note:

        s could be empty and contains only lowercase letters a-z.
        p could be empty and contains only lowercase letters a-z, and characters like . or *.
        Example 1:

        Input:
        s = "aa"
        p = "a"
        Output: false
        Explanation: "a" does not match the entire string "aa".
        Example 2:

        Input:
        s = "aa"
        p = "a*"
        Output: true
        Explanation: '*' means zero or more of the precedeng element, 'a'. Therefore, by repeating 'a' once, it becomes "aa".
        Example 3:

        Input:
        s = "ab"
        p = ".*"
        Output: true
        Explanation: ".*" means "zero or more (*) of any character (.)".
        Example 4:

        Input:
        s = "aab"
        p = "c*a*b"
        Output: true
        Explanation: c can be repeated 0 times, a can be repeated 1 time. Therefore it matches "aab".
        Example 5:

        Input:
        s = "mississippi"
        p = "mis*is*p*."
        Output: false
     */
    public static class RegularExpressionMatching
    {
        public static bool IsMatch(string s, string p)
        {
            char[] text = s.ToCharArray();
            char[] pattern = p.ToCharArray();


            bool[,] T = new bool[text.Length + 1, pattern.Length + 1];
            T[0, 0] = true;

            for (int i = 0; i < T.GetLength(0); i++)
            {
                if (pattern[i-1]=='*')
                {
                    T[0, i] = T[0, i - 2];
                }
            }
            for (int i = 1; i < T.GetLength(1); i++)
            {
                for (int j = 1; j < T.GetLength(0); j++)
                {
                    if (pattern[j-1]=='.' || pattern[j-1]==text[i-1])
                    {
                        T[i, j] = T[i - 1, j - 1];
                    }
                    else if (pattern[j-1]=='*')
                    {
                        //if there is 0 occurance of any char
                        T[i, j] = T[i, j - 2];
                        
                        if (pattern[j - 2] == '.' || pattern[j - 2] == text[i - 1])
                        {
                            T[i,j] = T[i,j] | T[i - 1,j];
                        }
                    }
                    else
                    {
                        T[i, j] = false;
                    }
                }
            }

            return T[text.Length, pattern.Length];
        }
        
    }
}
