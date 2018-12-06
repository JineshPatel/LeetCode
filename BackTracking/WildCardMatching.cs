using System;
using System.Collections.Generic;
using System.Text;

namespace BackTracking
{
    /*
     *   Given an input string (s) and a pattern (p), implement wildcard pattern matching with support for '?' and '*'.

        '?' Matches any single character.
        '*' Matches any sequence of characters (including the empty sequence).
        The matching should cover the entire input string (not partial).

        Note:

        s could be empty and contains only lowercase letters a-z.
        p could be empty and contains only lowercase letters a-z, and characters like ? or *.
        Example 1:

        Input:
        s = "aa"
        p = "a"
        Output: false
        Explanation: "a" does not match the entire string "aa".
        Example 2:

        Input:
        s = "aa"
        p = "*"
        Output: true
        Explanation: '*' matches any sequence.
        Example 3:

        Input:
        s = "cb"
        p = "?a"
        Output: false
        Explanation: '?' matches 'c', but the second letter is 'a', which does not match 'b'.
        Example 4:

        Input:
        s = "adceb"
        p = "*a*b"
        Output: true
        Explanation: The first '*' matches the empty sequence, while the second '*' matches the substring "dce".
        Example 5:

        Input:
        s = "acdcb"
        p = "a*c?b"
        Output: false
     */
    public static class WildCardMatching
    {
        public static bool isMatch(string st, string p)
        {
            char[] str = st.ToCharArray();
            char[] pattern = p.ToCharArray();

            int writeIndex = 0;
            bool isFirst = true;

            for (int i = 0; i < pattern.Length; i++)
            {
                if (pattern[i]=='*')
                {
                    if (isFirst)
                    {
                        pattern[writeIndex++] = pattern[i];
                        isFirst = false;
                    }
                }
                else
                {
                    pattern[writeIndex++] = pattern[i];
                    isFirst = true;
                }
            }

            bool[,] T = new bool[st.Length+1,writeIndex+1];

            if (writeIndex>0 && pattern[0]=='*')
            {
                T[0,1] = true;
            }

            T[0, 0] = true;

            for (int i = 1; i < T.GetLength(0); i++)
            {
                for (int j = 1; j < T.GetLength(1); j++)
                {
                    if (pattern[j - 1] == '?' || str[i - 1] == pattern[j - 1])
                    {
                        T[i, j] = T[i - 1, j - 1];
                    }
                    else if (pattern[j-1]=='*')
                    {
                        T[i, j] = T[i - 1, j] || T[i, j - 1];
                    }
                }
            }

            return T[st.Length, writeIndex];
        }
    }
}
